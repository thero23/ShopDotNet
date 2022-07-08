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

            CreateMap<ProviderCountry, ProviderCountryEntity>();
            CreateMap<ProviderCountryEntity, ProviderCountry>();

            CreateMap<Product, ProductEntity>();
            CreateMap<ProductEntity, Product>().ReverseMap();

            CreateMap<ProductInBasket, ProductInBasketEntity>().ReverseMap();
            CreateMap<BuyInOneClickEntity, BuyInOneClick>().ReverseMap();
            CreateMap<WhishListEntity, WhishList>().ReverseMap();
            // CreateMap<ProductInOrder, ProductInOrderEntity>().ForMember(x => x.ProductEntityId, y => y.MapFrom(z=> z.ProductId)).ForMember(x=> x.ProductEntity, y=> y.MapFrom(z=> z.Product)).ReverseMap();
            CreateMap<UserData, UserDataEntity>().ReverseMap();
            CreateMap<User, UserEntity>().ReverseMap();

            CreateMap<BasketEntity, Basket>().ForMember(x => x.ProductsBaskets, y => y.MapFrom(z => z.ProductBasketEntities)).ForMember(x => x.User, y => y.MapFrom(z => z.User)).ReverseMap();
            CreateMap<ProductBasket, ProductBasketEntity>().ForMember(x => x.Basket, y => y.MapFrom(z => z.Basket)).ForMember(x => x.Product, y => y.MapFrom(z => z.Product)).ReverseMap();
            // CreateMap<ProductBasketEntity, ProductBasket>().ForMember(x=> x.Bas, y => y.MapFrom(z=> z.Basket) .ReverseMap();
        }
    }
}
