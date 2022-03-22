using AutoMapper;
using InternetShop.ViewModels.Category;
using IS.BLL.Models;

namespace InternetShop.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();

            CreateMap<AddCategoryViewModel, Category>();
            CreateMap<UpdateCategoryViewModel, Category>();

        }
    }
}
