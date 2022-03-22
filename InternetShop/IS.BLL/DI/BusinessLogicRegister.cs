using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            services.AddDataAccess(config);
        }
    }
}
