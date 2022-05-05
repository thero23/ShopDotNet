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

            CreateMap<CurrencyEntity, Currency>();

            CreateMap<ProducerCountry, ProviderCountryEntity>();
            CreateMap<ProviderCountryEntity, ProducerCountry>();

            CreateMap<Product, ProductEntity>();
            CreateMap<ProductEntity, Product>();
            CreateMap<ProductEntity, ProductForBasket>();
            CreateMap<Product, ProductForBasket>();

            CreateMap<Basket, BasketEntity>();
            CreateMap<BasketEntity, Basket>()
                .ForMember(b => b.Products, x => x.MapFrom(b => b.ProductBasketEntities.Select(pb => pb.Product)));

            CreateMap<ProductBasketEntity, ProductForBasket>();
                /*.ForMember(x => x.QuantityInBasket, o => o.MapFrom(x => x.Quantity));*/



            CreateMap<ProductBasketEntity, ProductBasket>();
            CreateMap<ProductBasket, ProductBasketEntity>();
        }
    }
}
