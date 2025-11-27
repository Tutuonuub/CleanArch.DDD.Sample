using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository repository, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            var products = await _repository.GetAllWithCategoryAsync();
            return products.Adapt<IEnumerable<ProductViewModel>>();
        }

        public async Task<IEnumerable<ProductViewModel>> SearchAsync(string query)
        {
            var products = await _repository.SearchWithCategoryAsync(query);
            return products.Adapt<IEnumerable<ProductViewModel>>();
        }

        public async Task<ProductViewModel?> GetByIdAsync(int id)
        {
            var p = await _repository.GetByIdWithCategoryAsync(id);
            return p?.Adapt<ProductViewModel>();
        }

        public async Task AddAsync(ProductViewModel vm)
        {
            var entity = vm.Adapt<Product>();
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(ProductViewModel vm)
        {
            var entity = vm.Adapt<Product>();
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
