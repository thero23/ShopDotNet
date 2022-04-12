using AutoMapper;
using InternetShop.ViewModels.Category;
using InternetShop.ViewModels.Product;
using InternetShop.ViewModels.ProviderCountry;
using IS.BLL.Models;

namespace InternetShop.Mappers
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
        }
    }
}
