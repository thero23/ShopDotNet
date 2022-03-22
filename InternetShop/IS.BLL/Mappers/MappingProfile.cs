using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IS.BLL.Models;
using IS.DAL.Entities;

namespace IS.BLL.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryEntity, Category>().ReverseMap();
        }
    }
}
