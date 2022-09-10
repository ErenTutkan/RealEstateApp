using RealEstateApp.Application.Abstract;
using RealEstateApp.Core.Models;
using RealEstateApp.Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Application.Concrete
{
    public class EstateService : IEstateService
    {
        private readonly IEstateRepository _estateRepository;

        public EstateService(IEstateRepository estateRepository)
        {
            _estateRepository = estateRepository;
        }

        public async Task<Estate> CreateAsync(Estate entity)
        {
           return await _estateRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _estateRepository.DeleteAsync(id);
        }

        public async Task<Estate> GetAsync(int id)
        {
            return await _estateRepository.GetByIdAsync(id);
        }

        public async Task<List<Estate>> GetListAsync()
        {
            return await _estateRepository.GetListAsync();
        }

        public async Task<Estate> UpdateAsync(int id, Estate entity)
        {
            var updatedItem = await _estateRepository.GetByIdAsync(id);
            updatedItem.UpdateTime = DateTime.UtcNow;
            updatedItem.Details=entity.Details;
            updatedItem.Title = entity.Title;
            updatedItem.Address = entity.Address;
            updatedItem.BathSize = entity.BathSize;
            updatedItem.BedSize = entity.BedSize;
            updatedItem.RoomSize = entity.RoomSize;
            return await _estateRepository.UpdateAsync(id, updatedItem);
        }
    }
}
