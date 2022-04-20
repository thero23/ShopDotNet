using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.BLL.Services
{
    internal class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IProductBasketRepository _productBasketRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public BasketService(IMapper mapper, IBasketRepository basketRepository, IProductBasketRepository productBasketRepository, IProductRepository productRepository)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;
            _productBasketRepository = productBasketRepository;
            _productRepository = productRepository;
        }

        public Basket GetBasketWithProducts(string userId)
        {
            var basket = _basketRepository.GetByCondition(x => x.UserId.Equals(userId)).FirstOrDefault();
            if (basket is null) throw new ArgumentNullException();

            var result = _mapper.Map<Basket>(basket);
            var products = _productBasketRepository.GetByCondition(x => x.BasketId.Equals(basket.Id))
             .ToList();

            var test = products.Select(x => x.Quantity).ToList();

            result.Products = _mapper.Map<ICollection<Product>>(products);

            return result;

        }

        public async Task<Product> AddProductToBasketAsync(string userId, int productId, int quantity, CancellationToken ct)
        {
            var basket = _basketRepository.GetByCondition(x => x.UserId.Equals(userId)).FirstOrDefault();
            if (basket is null) throw new ArgumentNullException();

            var productBasketObject = new ProductBasket()
            {
                BasketId = basket.Id,
                ProductId = productId,
                Quantity = quantity,
            };
            await _productBasketRepository.Add(_mapper.Map<ProductBasketEntity>(productBasketObject), ct);
            var result = await _productRepository.GetById(productId, ct);

            if (result is null) throw new ArgumentNullException();

            return _mapper.Map<Product>(result);
        }

        public async Task RemoveProductFromBasketAsync(string userId, int productId, CancellationToken ct)
        {
            var basket = _basketRepository.GetByCondition(x => x.UserId.Equals(userId)).FirstOrDefault();
            if (basket is null) throw new ArgumentNullException();


            var basketProductToDelete = new ProductBasketEntity() { BasketId = basket.Id, ProductId = productId };
            await _productBasketRepository.Delete(basketProductToDelete, ct);


        }

        public async Task ClearBasketAsync(string userId, CancellationToken ct)
        {
            var basket = _basketRepository.GetByCondition(x => x.UserId.Equals(userId)).FirstOrDefault();
            if (basket is null) throw new ArgumentNullException();

            var allProducts = _productBasketRepository.GetByCondition(x => x.BasketId.Equals(basket.Id)).AsEnumerable();
            await _productBasketRepository.DeleteRange(allProducts, ct);
        }

        public async Task DeleteBasketAsync(string userId, CancellationToken ct)
        {
            var basket = _basketRepository.GetByCondition(x => x.UserId.Equals(userId)).FirstOrDefault();
            if (basket is null) throw new ArgumentNullException();
            await _basketRepository.Delete(basket, ct);
        }
    }
}
