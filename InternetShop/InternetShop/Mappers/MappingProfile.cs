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
            CreateMap<AddUserViewModel, UserData>().ReverseMap();

            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<OrderViewModel, ProductInOrder>().ForMember(x=> x.Product, y=> y.MapFrom(z=> z.ProductViewModel)).ReverseMap();

            CreateMap<Basket, BasketViewModel>();
            CreateMap<AddBasketViewModel, Basket>();
            CreateMap<UpdateBasketViewModel, Basket>();

            CreateMap<ProductBasket, ProductInBasketViewModel>();
            CreateMap<AddProductBasketViewModel, ProductBasket>();
            CreateMap<UpdateProductBasketViewModel, ProductBasket>().ReverseMap();

            CreateMap<ProductBasket, ProductBasketViewModel>().ReverseMap();

            CreateMap<ShortProductBasketViewModel, ProductBasket>().ReverseMap();

            CreateMap<UpdateProductBasketViewModel, ProductBasket>().ReverseMap();
        }
    }
}
