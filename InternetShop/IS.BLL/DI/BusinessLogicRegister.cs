using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.BLL.Services;
using IS.DAL.DI;
using IS.DAL.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IS.BLL.DI
{
    public static class BusinessLogicRegister
    {
        public static void AddBusinessLogic(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericService<Category>), typeof(GenericService<Category, CategoryEntity>));
            services.AddScoped(typeof(IGenericService<WhishList>), typeof(GenericService<WhishList, WhishListEntity>));
            services.AddScoped(typeof(IGenericService<SubCategoryName>), typeof(GenericService<SubCategoryName, SubCategoryNameEntity>));
            services.AddScoped(typeof(IGenericService<GeneralSubCategoryName>), typeof(GenericService<GeneralSubCategoryName, GeneralSubCategoryNameEntity>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IProviderCountryService, ProviderCountryService>();
            services.AddScoped<IBuyInOneClickService, BuyInOneClickService>();
            services.AddScoped<IWhishListService, WhishListService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IProductBasketService, ProductBasketService>();
            services.AddScoped<ISubCategoryService, SubCategoryService>();
            services.AddDataAccess(config);
        }
    }
}
