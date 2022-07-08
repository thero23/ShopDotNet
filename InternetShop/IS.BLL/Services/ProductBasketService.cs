using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProductBasketService : GenericService<ProductBasket, ProductBasketEntity>, IProductBasketService
    {
        private readonly IProductBasketRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IBasketService _basketService;
        private readonly IProductRepository _productRepository;
        public ProductBasketService(IProductBasketRepository repository,
            IUserService userService,
            IMapper mapper,
            IBasketService basketService,
            IProductRepository productRepository) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _userService = userService;
            _basketService = basketService;
            _productRepository = productRepository;
        }

        public async Task<ProductBasket> AddProductToBasket(string userId, int productId, CancellationToken ct)
        {
            var user = await _userService.GetById(userId, ct);
            var basket = await _basketService.GetBasketByUserId(user.Id, ct);
            var product = await _productRepository.GetById(productId, ct);

            var productInBasket = await _repository.GetByBasketIdAndProductId(basket.Id, product.Id, ct);
            if (productInBasket is not null)
            {
                productInBasket.Count += 1;
                var results = await _repository.Update(productInBasket, ct);
                return _mapper.Map<ProductBasketEntity, ProductBasket>(results);
            }
            var result = await _repository.Add(new ProductBasketEntity { ProductId = product.Id, BasketId = basket.Id, Count = 1 }, ct);

            return _mapper.Map<ProductBasket>(result);
        }

        public async ValueTask Delete(string basketId, int productId, CancellationToken ct)
        {
            var product = await _repository.GetByBasketIdAndProductId(basketId, productId, ct);
            if(product is not null)
            {
                await _repository.Delete(product, ct);
            }
        }

        public async Task<ProductBasket> Put(ProductBasket product, CancellationToken ct)
        {
            var basket = await _repository.GetByBasketIdAndProductId(product.BasketId, product.ProductId, ct);
            var result = _mapper.Map<ProductBasketEntity>(product);
            result.Basket = basket.Basket;
            return _mapper.Map<ProductBasket>(await _repository.Update(result, ct));
        }
    }
}
