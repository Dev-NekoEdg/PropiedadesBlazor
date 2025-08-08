using AutoMapper;
using Propiedades.Data.Models;
using Propiedades.DTOs;

namespace Propiedades.Mapper
{
    public class ConfigurationMapper : Profile
    {
        public ConfigurationMapper()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
