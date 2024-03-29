﻿using AutoMapper;
using IS.BLL.Models;
using IS.DAL.Entities;

namespace IS.BLL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryEntity, Category>();
            CreateMap<Category, CategoryEntity>();

            CreateMap<ProviderCountry, ProviderCountryEntity>();
            CreateMap<ProviderCountryEntity, ProviderCountry>();

            CreateMap<Product, ProductEntity>();
            CreateMap<ProductEntity, Product>();
        }
    }
}
