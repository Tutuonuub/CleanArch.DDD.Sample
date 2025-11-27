using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _ctx;
        public CategoryRepository(ApplicationDbContext ctx) => _ctx = ctx;

        public async Task AddAsync(Category category)
        {
            _ctx.Categories.Add(category);
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var e = await _ctx.Categories.FindAsync(id);
            if (e != null)
            {
                _ctx.Categories.Remove(e);
                await _ctx.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _ctx.Categories.AsNoTracking().ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _ctx.Categories.FindAsync(id);
        }

        public async Task UpdateAsync(Category category)
        {
            _ctx.Categories.Update(category);
            await _ctx.SaveChangesAsync();
        }
    }
}
