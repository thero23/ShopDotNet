using AutoMapper;
using InternetShop.API.ViewModels.Category;
using InternetShop.Api.ViewModels.Product;
using InternetShop.API.ViewModels.Product;
using InternetShop.Api.ViewModels.ProductInBasket;
using InternetShop.API.ViewModels.ProviderCountry;
using IS.BLL.Models;
using InternetShop.Api.ViewModels.WhishList;
using InternetShop.Api.ViewModels.User;
using InternetShop.Api.ViewModels.Order;
using InternetShop.Api.ViewModels.Basket;
using InternetShop.Api.ViewModels.ProductBasket;
using InternetShop.Api.ViewModels.OrderProduct;
using InternetShop.Api.ViewModels.SubCategories;
using InternetShop.Api.ViewModels.Characteristics;
using InternetShop.Api.ViewModels.Characteristics.AdditionalCharacteristics;
using InternetShop.Api.ViewModels.Equals;
using InternetShop.Api.ViewModels.ProductsCharacteristic;

namespace InternetShop.API.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
            CreateMap<AddCategoryViewModel, Category>();
            CreateMap<UpdateCategoryViewModel, Category>();

            CreateMap<AddProductViewModel, Product>();
            CreateMap<UpdateProductViewModel, Product>();
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Product, ShortProductViewModel>();

            CreateMap<AddProviderCountryViewModel, ProviderCountry>();
            CreateMap<ProviderCountry, ProviderCountryViewModel>();
            CreateMap<UpdateProviderCountryViewModel, ProviderCountry>();

            CreateMap<ProductInBasketViewModel, ProductInBasket>().ReverseMap();
            CreateMap<AddProductInBasketViewModel, ProductInBasket>().ReverseMap();
            CreateMap<BuyInOneClickViewModel, BuyInOneClick>().ReverseMap();
            CreateMap<WhishList, WhishListViewModel>().ReverseMap();
            CreateMap<WhishListAddViewModel, WhishList>().ReverseMap();
            CreateMap<UpdateProductInBasketViewModel, ProductInBasket>().ReverseMap();
            CreateMap<AddProductInBasketViewModel, ProductInOrder>().ReverseMap();

            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<OrderViewModel, Order>().ReverseMap().ForMember(x=> x.OrderProduct, y=> y.MapFrom(z=> z.OrderProduct));

            CreateMap<OrderProduct, OrderProductViewModel>().ReverseMap();

            CreateMap<Basket, BasketViewModel>();
            CreateMap<AddBasketViewModel, Basket>();
            CreateMap<UpdateBasketViewModel, Basket>();

            CreateMap<ProductBasket, ProductInBasketViewModel>();
            CreateMap<AddProductBasketViewModel, ProductBasket>();
            CreateMap<UpdateProductBasketViewModel, ProductBasket>().ReverseMap();

            CreateMap<ProductBasket, ProductBasketViewModel>().ReverseMap();

            CreateMap<ShortProductBasketViewModel, ProductBasket>().ReverseMap();

            CreateMap<UpdateProductBasketViewModel, ProductBasket>().ReverseMap();

            CreateMap<SubCategoryViewModel, SubCategory>().ReverseMap();
            CreateMap<GeneralSubCategoryNameViewModel, GeneralSubCategoryName>().ReverseMap();
            CreateMap<SubCategoryNameViewModel, SubCategoryName>().ReverseMap();
            CreateMap<AddSubCategoryViewModel, SubCategory>().ReverseMap();
            CreateMap<AddGeneralSubCategoryNameViewModel, GeneralSubCategoryName>().ReverseMap().ForMember(x=> x.SubCategoryId, y=> y.MapFrom(z=> z.SubCategoriesName));
            CreateMap<AddSubCategoryNameViewModel, SubCategoryName>().ReverseMap();

            CreateMap<CharacteristicsViewModel, Characteristics>().ReverseMap();
            CreateMap<AdditionalCharacteristics, AdditionalCharacteristicsViewModel>().ReverseMap();

            CreateMap<EqualsViewModel, Equals>().ReverseMap();
            CreateMap<AddEqualsViewModel, Equals>().ReverseMap();
            CreateMap<ProductsCharacteristicViewModel, ProductsCharacteristic>().ReverseMap();

            CreateMap<ProductsCharacteristic, CharacteristicsViewModel>().ReverseMap();
        }
    }
}
