using CleanArch.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
        Task<IEnumerable<ProductViewModel>> SearchAsync(string query);
        Task<ProductViewModel?> GetByIdAsync(int id);
        Task AddAsync(ProductViewModel vm);
        Task UpdateAsync(ProductViewModel vm);
        Task DeleteAsync(int id);
    }
}
