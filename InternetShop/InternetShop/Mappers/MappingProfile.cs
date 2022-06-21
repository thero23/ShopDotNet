using AutoMapper;
using InternetShop.API.ViewModels.Category;
using InternetShop.Api.ViewModels.Product;
using InternetShop.API.ViewModels.Product;
using InternetShop.Api.ViewModels.ProductInBasket;
using InternetShop.API.ViewModels.ProviderCountry;
using IS.BLL.Models;
using InternetShop.Api.ViewModels.WhishList;
using InternetShop.Api.ViewModels.User;

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
            CreateMap<Product, ProductViewModel>();
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
        }
    }
}
