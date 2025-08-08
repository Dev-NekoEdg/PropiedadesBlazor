using Propiedades.DTOs;

namespace Propiedades.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryDTO>> GetAllAsync();
        Task<CategoryDTO> GetByIdAsync(int id);
        Task<CategoryDTO> GetByNameAsync(string name);
        Task<CategoryDTO> CreateAsync(CategoryDTO category);
        Task<CategoryDTO> UpdateAsync(int id, CategoryDTO category);
        Task<bool> DeleteAsync(int id);
    }


}
