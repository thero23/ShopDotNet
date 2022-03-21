﻿using IS.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IS.DAL.DI
{
    public static class DataAccessRegister
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DatabaseContext>(context =>
            {
                context.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
