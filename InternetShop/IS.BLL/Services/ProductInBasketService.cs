using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProductInBasketService : GenericService<ProductInBasket, ProductInBasketEntity>, IProductInBasketService
    {
        private readonly IProductInBasketRepository _repository;
        private readonly IMapper _mapper;

        public ProductInBasketService(IProductInBasketRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductInBasket>> GetById(int id, CancellationToken ct)
        {
            var products = await _repository.GetById(id, ct);
            return _mapper.Map<IEnumerable<ProductInBasket>>(products);
        }

        public async Task<IEnumerable<ProductInBasket>> Update(IEnumerable<ProductInBasket> productsInBaskets, CancellationToken ct)
        {
            var products = await _repository.Update(_mapper.Map<IEnumerable<ProductInBasketEntity>>(productsInBaskets), ct);
            return _mapper.Map<IEnumerable<ProductInBasket>>(products);
        }
    }
}
