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
        private readonly IUserRepository _userRepository;

        public BasketService(IBasketRepository repository, IMapper mapper, IUserRepository userRepository) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<Basket> GetBasketByUserId(string id, CancellationToken ct)
        {
            var result = await _repository.GetByAuth0Id(id, ct);
            return _mapper.Map<Basket>(result);
        }
       
        public async Task<IEnumerable<ProductBasket>> GetBasketWithProductsByUserId(string authId, CancellationToken ct)
        {
            var user = await _userRepository.GetById(authId, ct);
            var basket = await _repository.GetProductsBasketByUserId(user.Id, ct);
            var test = basket.ProductBasketEntities;
            var result = _mapper.Map<IEnumerable<ProductBasket>>(basket.ProductBasketEntities);
            return _mapper.Map<IEnumerable<ProductBasket>>(result);
        }
    }
}
