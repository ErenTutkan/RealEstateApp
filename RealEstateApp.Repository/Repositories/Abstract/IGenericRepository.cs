using RealEstateApp.Core.Abstract;
using RealEstateApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Repository.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : class,IEntity,new ()
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int id,T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task SaveAsync();
    }
}
