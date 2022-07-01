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
            CreateMap<ProductInOrder, ProductInOrderEntity>().ForMember(x => x.ProductEntityId, y => y.MapFrom(z=> z.ProductId)).ReverseMap();
            CreateMap<UserData, UserDataEntity>().ReverseMap();
            CreateMap<User, UserEntity>().ReverseMap();
        }
    }
}
