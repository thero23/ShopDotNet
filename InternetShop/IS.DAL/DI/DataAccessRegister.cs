using IS.DAL.Contexts;
using IS.DAL.Contexts.Configurations;
using IS.DAL.Interfaces;
using IS.DAL.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IS.DAL.DI
{
    public static class DataAccessRegister
    {
        public static IConfiguration Configuration { get; set; }
        public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            Configuration = config;
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
         
            services.AddTransient<IProductRepository, ProductRepository>();
           // services.AddScoped<IProductRepository, ProductRepository>();
            services.Configure<Settings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.DatabaseName = Configuration.GetSection("MongoConnection: Database").Value;
            });

            services.AddDbContext<DatabaseContext>(context =>
            {
                context.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
