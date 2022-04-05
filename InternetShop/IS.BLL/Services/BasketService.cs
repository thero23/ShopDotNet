using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    internal class BasketService : GenericService<Basket, BasketEntity>, IBasketService
    {
        public BasketService(IBasketRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
