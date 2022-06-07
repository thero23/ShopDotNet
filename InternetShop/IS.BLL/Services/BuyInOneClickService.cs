using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class BuyInOneClickService : GenericService<BuyInOneClick, BuyInOneClickEntity> , IBuyInOneClickService
    {
        public BuyInOneClickService(IBuyInOneClickRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
