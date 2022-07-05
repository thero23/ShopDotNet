using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class BasketService : GenericService<Basket, BasketEntity>, IBasketService
    {
        private readonly IBasketRepository _repository;
        private readonly IMapper _mapper;

        public BasketService(IBasketRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Basket> GetBasketByUserId(string id, CancellationToken ct)
        {
           // var result = await _repository.GetByUserId(id, ct);
            return null;
        }

        /* public async Task<IEnumerable<ProductInBasket>> GetById(string id, CancellationToken ct)
         {
             var products = await _repository.GetById(id, ct);
             return _mapper.Map<IEnumerable<ProductInBasket>>(products);
         }

         public async Task<IEnumerable<ProductInBasket>> Update(IEnumerable<ProductInBasket> productsInBaskets, CancellationToken ct)
         {
             var products = await _repository.Update(_mapper.Map<IEnumerable<ProductInBasketEntity>>(productsInBaskets), ct);
             return _mapper.Map<IEnumerable<ProductInBasket>>(products);
         }*/
    }
}
