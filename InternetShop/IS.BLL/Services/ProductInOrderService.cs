using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProductInOrderService : GenericService<ProductInOrder, ProductInOrderEntity>, IProductInOrderService
    {
        private readonly IProductInBasketService _productInBasketService;
        private readonly IMapper _mapper;
        private readonly IUserDataService _userDataService;
        private readonly IProductService _productService;
        private readonly IProductInOrderRepository _repository;
        private readonly IProductInBasketRepository _productInBasketRepository;
        private readonly IUserService _userService;
        public ProductInOrderService(IProductInOrderRepository repository,
            IMapper mapper,
            IProductInBasketService productInBasketService, 
            IUserDataService userDataService, 
            IUserService userService, 
            IProductInBasketRepository productInBasketRepository,
            IProductService productService) : base(repository, mapper)
        {
            _productInBasketService = productInBasketService;
            _mapper = mapper;
            _userDataService = userDataService;
            _repository = repository;
            _userService = userService;
            _productInBasketRepository = productInBasketRepository;
            _productService = productService;
        }

        public async Task<IEnumerable<ProductInOrder>> Post(User userData, CancellationToken ct)
        {
            var user = await _userService.GetById(userData.Auth0Id, ct);
            if(user is null)
            {
                await _userService.Add(new User { FirstName = userData.FirstName, LastName = userData.LastName, PhoneNumber = userData.PhoneNumber, Auth0Id = userData.Auth0Id }, ct);
            }

            var products = await GetProductInBasketByuserId(userData.Auth0Id, ct);

            var productsInOrder = _mapper.Map<IEnumerable<ProductInOrderEntity>>(CreateInstance(userData, products));

            var result = await _repository.AddRange(productsInOrder, ct);

            await _productInBasketRepository.DeleteProductsFromBasket(_mapper.Map<IEnumerable<ProductInBasketEntity>>(products), ct);

            return _mapper.Map<IEnumerable<ProductInOrder>>(result);
        }

        private async Task<IEnumerable<ProductInBasket>> GetProductInBasketByuserId(string userId, CancellationToken ct)
        {
            return await _productInBasketService.GetById(userId, ct);
        }

        private IEnumerable<ProductInOrder> CreateInstance(User user, IEnumerable<ProductInBasket> productsInBasket)
        {
            var productInOrder = new List<ProductInOrder>();
            var orderNumber = new Random().Next();
            foreach (var el in productsInBasket)
            {
                productInOrder.Add(new ProductInOrder
                {
                    OrderNumber = orderNumber,
                    Count = el.Count,
                    Price = el.Price,
                    UserId = user.Auth0Id,
                    ProductId = el.Id,
                    CreatedAt = DateTime.UtcNow
                });
            }
            return productInOrder;
        }

        public async Task<IEnumerable<ProductInOrder>> GetByUserId(string id, CancellationToken ct)
        {
            var result = await _repository.GetByUserId(id, ct);
            return _mapper.Map<IEnumerable<ProductInOrder>>(result);
        }
    }
}
