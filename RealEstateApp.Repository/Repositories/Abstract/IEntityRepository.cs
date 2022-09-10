using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Repository.Repositories.Abstract
{
    public interface IEntityRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int id,T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task SaveAsync();
    }
}
