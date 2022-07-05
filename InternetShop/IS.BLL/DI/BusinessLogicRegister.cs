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
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IProviderCountryService, ProviderCountryService>();
            services.AddScoped<IBuyInOneClickService, BuyInOneClickService>();
            services.AddScoped<IWhishListService, WhishListService>();
            services.AddScoped<IProductInOrderService, ProductInOrderService>();
            services.AddScoped<IUserDataService, UserDataService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IProductBasketService, ProductBasketService>();
            services.AddDataAccess(config);
        }
    }
}
