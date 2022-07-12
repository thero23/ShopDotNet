using IS.DAL.Contexts;
using IS.DAL.Interfaces;
using IS.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IS.DAL.DI
{
    public static class DataAccessRegister
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
         
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProviderCountryRepository, ProviderCountryRepository>();
            services.AddScoped<IBuyInOneClickRepository, BuyInOneClickRepository>();
            services.AddScoped<IWhishListRepository, WhishListRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUserDataRepository, UserDataRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IProductBasketRepository, ProductBasketRepository>();
            services.AddScoped<IOrderProductRepository, OrderProductsRepository>();
            services.AddDbContext<DatabaseContext>(context =>
            {
                context.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
