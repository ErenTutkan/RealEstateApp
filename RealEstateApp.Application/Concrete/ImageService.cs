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
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<Image> CreateAsync(Image entity)
        {
            return await _imageRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _imageRepository.DeleteAsync(id);
        }

        public Task<Image> GetAsync(int id)
        {
            return _imageRepository.GetByIdAsync(id);
        }
        public async Task<List<Image>> GetListAsync()
        {
            return await _imageRepository.GetListAsync();
        }


        public async Task<Image> UpdateAsync(int id, Image entity)
        {
            var updatedImage =await GetAsync(id);
            updatedImage.UpdateTime = DateTime.UtcNow;
            updatedImage.ImageUrl=entity.ImageUrl;
            return await _imageRepository.UpdateAsync(id,updatedImage);
        }
    }
}
