using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Propiedades.Data;
using Propiedades.Data.Models;
using Propiedades.DTOs;

namespace Propiedades.Repositories
{
    public class EstateRepository : IEstateRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public EstateRepository(
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<EstateDTO> CreateAsync(EstateDTO estate)
        {
            var newEstate = mapper.Map<Estate>(estate);

            await context.Estate.AddAsync(newEstate);
            await context.SaveChangesAsync();

            return mapper.Map<EstateDTO>(newEstate); ;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var oldEstate = context.Estate.FirstOrDefault(x => x.Id == id);
            if (oldEstate != null)
            {
                context.Estate.Remove(oldEstate);
                await context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<EstateDTO>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<Estate>, IEnumerable<EstateDTO>>(context.Estate);
        }

        public async Task<EstateDTO> GetByIdAsync(int id)
        {
            var estate = await context.Estate.FirstOrDefaultAsync(x=> x.Id == id);
            return mapper.Map<EstateDTO>(estate);
        }

        public async Task<EstateDTO> GetByNameAsync(string name)
        {
            var estate = await context.Estate.FirstOrDefaultAsync(x => x.Name.ToUpper().Equals(name.ToUpper()));
            return mapper.Map<EstateDTO>(estate);
        }

        public async Task<EstateDTO> UpdateAsync(int id, EstateDTO estate)
        {
            var oldEstate = await context.Estate.FirstOrDefaultAsync(c => c.Id == id);
            if (oldEstate != null)
            {
                oldEstate.Name = estate.Name;
                oldEstate.Description = estate.Description;

                oldEstate.UpdateDate = DateTime.Now;
                await context.SaveChangesAsync();

                return mapper.Map<EstateDTO>(oldEstate);

            }
            return null;
        }
    }


}
