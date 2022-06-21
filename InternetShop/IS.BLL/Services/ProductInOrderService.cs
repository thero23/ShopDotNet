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
        private readonly IProductInOrderRepository _repository;
        public ProductInOrderService(IProductInOrderRepository repository, IMapper mapper, IProductInBasketService productInBasketService, IUserDataService userDataService) : base(repository, mapper)
        {
            _productInBasketService = productInBasketService;
            _mapper = mapper;
            _userDataService = userDataService;
            _repository = repository;
        }

        public async Task<IEnumerable<ProductInOrder>> Post(UserData userData, CancellationToken ct)
        {
            await _userDataService.Add(new UserData { FirstName = userData.FirstName, AddressToDelivery = userData.AddressToDelivery, LastName = userData.LastName, PhoneNumber = userData.PhoneNumber, UserId = userData.UserId}, ct);

            var userDataResult = await _userDataService.GetLastUserDataById(1, ct);

            var products = await GetProductInBasketByuserId(userData.UserId, ct);

            var productsInOrder = _mapper.Map<IEnumerable<ProductInOrderEntity>>(CreateInstance(userDataResult, products));

            var result = await _repository.AddRange(productsInOrder, ct);
            
            return _mapper.Map<IEnumerable<ProductInOrder>>(result);
        }

        private async Task<IEnumerable<ProductInBasket>> GetProductInBasketByuserId (int userId, CancellationToken ct)
        {
            return await _productInBasketService.GetById(userId, ct);
        }

        private IEnumerable<ProductInOrder> CreateInstance(UserData userData, IEnumerable<ProductInBasket> productsInBasket)
        {
            var productInOrder = new List<ProductInOrder>();
            var orderNumber = new Random().Next();
            userData.Id = new Random().Next();
            foreach(var el in productsInBasket)
            {
                productInOrder.Add(new ProductInOrder
                {
                    OrderNumber = orderNumber,
                    ProductId = el.Id,
                    UserData = userData,
                    UserDataId = userData.Id
                });
            }
            return productInOrder;
        }

    }
}
