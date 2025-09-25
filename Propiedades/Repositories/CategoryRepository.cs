using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Propiedades.Data;
using Propiedades.Data.Models;
using Propiedades.DTOs;

namespace Propiedades.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CategoryRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<CategoryDTO> CreateAsync(CategoryDTO category)
        {
            var newCategory = this.mapper.Map<Category>(category);

            await context.Category.AddAsync(newCategory);
            await context.SaveChangesAsync();

            return this.mapper.Map<CategoryDTO>(newCategory);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var category = await context.Category.FirstOrDefaultAsync(c => c.Id == id);

            if (category != null)
            {
                context.Category.Remove(category);
                await context.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(context.Category);
        }

        public async Task<CategoryDTO> GetByIdAsync(int id)
        {
            var foundCategory = await context.Category.FirstOrDefaultAsync(c => c.Id == id);
            return mapper.Map<CategoryDTO>(foundCategory);
        }

        public async Task<CategoryDTO> GetByNameAsync(string name)
        {
            var foundCategory = await context.Category.FirstOrDefaultAsync(c => c.Name.ToUpper().Equals(name.ToUpper()));
            return mapper.Map<CategoryDTO>(foundCategory);
        }

        public async Task<CategoryDTO> UpdateAsync(int id, CategoryDTO category)
        {
            var oldCategory = await context.Category.FirstOrDefaultAsync(c => c.Id == id);
            if (oldCategory != null)
            {
                oldCategory.Name = category.Name;
                oldCategory.Description = category.Description;
                oldCategory.UpdateAt = DateTime.Now;
                await context.SaveChangesAsync();

                return mapper.Map<CategoryDTO>(oldCategory);

            }

            return null;
        }
    }


}
