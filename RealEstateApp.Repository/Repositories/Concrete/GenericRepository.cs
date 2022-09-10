using Microsoft.EntityFrameworkCore;
using RealEstateApp.Core.Abstract;
using RealEstateApp.Core.Models;
using RealEstateApp.Repository.Context;
using RealEstateApp.Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Repository.Repositories.Concrete
{
    public class GenericRepository<T> :IGenericRepository<T> where T:class,IEntity,new()
    {
        private readonly SqlServerDbContext _connection;
       
        public GenericRepository(SqlServerDbContext connection)
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
            Item.IsDelete = true;
            await UpdateAsync(id, Item);
            await SaveAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result =await _connection.Set<T>().Where(x=>!x.IsDelete).FirstOrDefaultAsync(x=>x.Id==id);
            return result;
        }

        public async Task<List<T>> GetListAsync()
        {
            var result = await _connection.Set<T>().Where(x=>!x.IsDelete).ToListAsync();
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
