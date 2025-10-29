using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductViewModel?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return null;
            return MapToVm(entity);
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            var list = await _repository.GetAllAsync();
            return list.Select(MapToVm);
        }

        public async Task<ProductViewModel> CreateAsync(ProductViewModel vm)
        {
            var entity = new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Price = vm.Price
            };

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            vm.Id = entity.Id;
            return vm;
        }

        public async Task UpdateAsync(ProductViewModel vm)
        {
            var entity = await _repository.GetByIdAsync(vm.Id);
            if (entity == null) throw new KeyNotFoundException("Produto não encontrado");

            entity.Name = vm.Name;
            entity.Description = vm.Description;
            entity.Price = vm.Price;

            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) throw new KeyNotFoundException("Produto não encontrado");

            _repository.Remove(entity);
            await _repository.SaveChangesAsync();
        }

        private static ProductViewModel MapToVm(Product p)
        {
            return new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            };
        }
    }
}
