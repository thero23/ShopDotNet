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
        private readonly IProductService _productService;
        public ProductBasketService(IProductBasketRepository repository,
            IUserService userService,
            IMapper mapper,
            IBasketService basketService,
            IProductService productService) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _userService = userService;
            _basketService = basketService;
            _productService = productService;
        }

        public async Task<IEnumerable<ProductBasket>> AddProductToBasket(string id, CancellationToken ct)
        {
            var user = await _userService.GetById("google-oauth2|110601127660968932340", ct);
            var basket = _basketService.GetBasketByUserId(user.Id, ct);
            var test = _productService.GetAll(ct).Result.ToList();
            var result = await _repository.Add(new ProductBasketEntity { Basket = _mapper.Map<BasketEntity>(basket), Count = 1, Product = _mapper.Map<ProductEntity>(test[0])}, ct);
            return (IEnumerable<ProductBasket>)result;
        }
    }
}
