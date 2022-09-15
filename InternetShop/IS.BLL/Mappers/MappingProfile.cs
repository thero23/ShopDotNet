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

            CreateMap<Product, ProductEntity>().ReverseMap().ForMember(x => x.Characteristics, y => y.MapFrom(z => z.ProductsCharacteristics.Select(x => x.Characteristics)));

            CreateMap<ProductInBasket, ProductInBasketEntity>().ReverseMap();
            CreateMap<BuyInOneClickEntity, BuyInOneClick>().ReverseMap();
            CreateMap<WhishListEntity, WhishList>().ReverseMap();
            CreateMap<User, UserEntity>().ReverseMap();
            CreateMap<CurrencyEntity, Currency>().ReverseMap();

            CreateMap<BasketEntity, Basket>().ForMember(x => x.ProductsBaskets, y => y.MapFrom(z => z.ProductBasketEntities)).ForMember(x => x.User, y => y.MapFrom(z => z.User)).ReverseMap();
            CreateMap<ProductBasket, ProductBasketEntity>().ForMember(x => x.Basket, y => y.MapFrom(z => z.Basket)).ForMember(x => x.Product, y => y.MapFrom(z => z.Product)).ReverseMap();
            CreateMap<OrderEntity, Order>().ForMember(x => x.OrderProduct, y => y.MapFrom(z => z.OrderProductEntities));
            CreateMap<OrderProductEntity, OrderProduct>();//.ReverseMap().ForMember(x=> x.Product, y=> y.MapFrom(z=> z.Product)).ForMember(x=> x.Order, y=> y.MapFrom(z=> z.Order));

            CreateMap<SubCategory, SubCategoryEntity>().ReverseMap();
            CreateMap<SubCategoryName, SubCategoryNameEntity>().ReverseMap();
            CreateMap<GeneralSubCategoryName, GeneralSubCategoryNameEntity>().ReverseMap();

            CreateMap<Characteristics, CharacteristicsEntity>().ReverseMap();
            CreateMap<AdditionalCharacteristics, AdditionalCharacteristicsEntity>().ReverseMap();

            CreateMap<Equals, EqualsEntity>().ReverseMap();

            CreateMap<ProductsCharacteristicEntity, ProductsCharacteristic>().ReverseMap();
            CreateMap<ProductsCharacteristicEntity, CharacteristicsEntity>().ReverseMap().ForMember(x => x.Characteristics, y => y.MapFrom(z => z.ProductsCharacteristics));
        }
    }
}
