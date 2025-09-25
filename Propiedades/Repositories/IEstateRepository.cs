using Propiedades.DTOs;

namespace Propiedades.Repositories
{
    public interface IEstateRepository
    {
        Task<IEnumerable<EstateDTO>> GetAllAsync();
        Task<EstateDTO> GetByIdAsync(int id);
        Task<EstateDTO> GetByNameAsync(string name);
        Task<EstateDTO> CreateAsync(EstateDTO category);
        Task<EstateDTO> UpdateAsync(int id, EstateDTO category);
        Task<bool> DeleteAsync(int id);
    }
}
