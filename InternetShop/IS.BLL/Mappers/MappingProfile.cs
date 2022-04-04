using AutoMapper;
using IS.BLL.Models;
using IS.DAL.Entities;

namespace IS.BLL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryEntity, Category>();
            CreateMap<Category, CategoryEntity>();

            CreateMap<ProducerCountry, ProviderCountryEntity>();
            CreateMap<ProviderCountryEntity, ProducerCountry>();

            CreateMap<Product, ProductEntity>();
            CreateMap<ProductEntity, Product>();
        }
    }
}
