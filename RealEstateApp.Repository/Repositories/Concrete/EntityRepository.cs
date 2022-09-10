﻿using Microsoft.EntityFrameworkCore;
using RealEstateApp.Repository.Context;
using RealEstateApp.Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Repository.Repositories.Concrete
{
    public class EntityRepository<T> where T :class, IEntityRepository<T>
    {
        private readonly SqlServerDbContext _connection;
       
        public EntityRepository(SqlServerDbContext connection)
        {
            _connection = connection;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _connection.Set<T>().AddAsync(entity);
            await SaveAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var Item =await GetByIdAsync(id);
            _connection.Remove<T>(Item);
            await SaveAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result =await _connection.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<List<T>> GetListAsync()
        {
            var result = await _connection.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> UpdateAsync(int id,T entity)
        {
           _connection.Set<T>().Update(entity);
           await SaveAsync();

            return entity;
        }
        public async Task SaveAsync()
        {
            await _connection.SaveChangesAsync();
        }
    }
}
