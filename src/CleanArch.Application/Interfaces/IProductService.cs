using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
        Task<ProductViewModel?> GetByIdAsync(int id);
        Task<ProductViewModel> CreateAsync(ProductViewModel vm);
        Task UpdateAsync(ProductViewModel vm);
        Task DeleteAsync(int id);
    }
}
