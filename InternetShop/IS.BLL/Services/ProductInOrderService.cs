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
        public ProductInOrderService(IGenericRepository<ProductInOrderEntity> repository, IMapper mapper, IProductInBasketService productInBasketService) : base(repository, mapper)
        {
            _productInBasketService = productInBasketService;
            _mapper = mapper;
        }

        public async Task<ProductInOrder> Post(ProductInOrder productInOrder, CancellationToken ct)
        {
            var products = await GetProductInBasketByuserId(productInOrder.UserId, ct);
            return null;
        }

        private async Task<IEnumerable<ProductInBasket>> GetProductInBasketByuserId (int userId, CancellationToken ct)
        {
            return await _productInBasketService.GetById(userId, ct);
        }
    }
}
