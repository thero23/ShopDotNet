using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class OrderService : GenericService<Order, OrderEntity>, IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _repository;
        private readonly IProductBasketRepository _productBasketRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        public OrderService(IOrderRepository repository,
            IMapper mapper,
            IUserService userService,
            IProductBasketRepository productBasketRepository,
            IBasketRepository basketRepository,
            IOrderProductRepository orderProductRepository) : base(repository, mapper)
        {
            _mapper = mapper;
            _repository = repository;
            _productBasketRepository = productBasketRepository;
            _basketRepository = basketRepository;
            _orderProductRepository = orderProductRepository;
        }

        public async Task<Order> Post(User userData, CancellationToken ct)
        {
            var basket = await _basketRepository.GetByUserId(userData.Id, ct);

            var products = await _productBasketRepository.GetProductsByBasketId(basket.Id, ct);

            var orderInstance = CreateOrder(products, userData.Id, ct);

            var order = await _repository.Add(orderInstance, ct);

            await _orderProductRepository.AddRange(CreateList(products, order), ct);

            await _productBasketRepository.DeleteProductsbasketRange(products, ct);

            return _mapper.Map<Order>(order);
        }

        private IEnumerable<OrderProductEntity> CreateList(IEnumerable<ProductBasketEntity> products, OrderEntity order)
        {
            var orderProductEntities = new List<OrderProductEntity>();
            foreach (var el in products)
            {
                orderProductEntities.Add(new OrderProductEntity { OrderId = order.Id, ProductId = el.ProductId, Count = el.Count, Price = CalculatePriceWithDiscount(el.Product.Discount, el.Product.Price) }); ;
            }
            return orderProductEntities;
        }

        private decimal CalculatePriceWithDiscount(int discount, decimal price)
        {
            return (100 - discount) / 100 * price;
        }

        private OrderEntity CreateOrder(IEnumerable<ProductBasketEntity> products, string userId, CancellationToken ct)
        {
            return new OrderEntity
            {
                TotalPrice = CalculateGeneralSumOfProducts(products, ct),
                OrderNumber = new Random().Next(1, int.MaxValue).ToString(),
                CreatedAt = DateTime.UtcNow,
                UserId = userId,
            };
        }

        private decimal CalculateGeneralSumOfProducts(IEnumerable<ProductBasketEntity> products, CancellationToken ct)
        {
            decimal totalPrice = 0m;

            foreach (var el in products)
            {
                totalPrice += el.Product.Price * el.Count;
            }

            return totalPrice;
        }


        public async Task<IEnumerable<Order>> GetByUserId(string id, CancellationToken ct)
        {
            var result = await _repository.GetByUserId("00c30afb-6ac8-4336-8b05-8d95f7430f44", ct);
            return _mapper.Map<IEnumerable<Order>>(result);
        }
    }
}
