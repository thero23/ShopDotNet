using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProductService:GenericService<Product, ProductEntity>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override async Task<IEnumerable<Product>> GetAll(CancellationToken ct)
        {
            var products = await _repository.GetAll(ct);

            var mappedProductsList = _mapper.Map<IEnumerable<Product>>(products).ToList();
       
            
            foreach (var product in mappedProductsList)
            {
                product.PriceWithDiscount = (decimal)(100 - product.Discount) / 100 * product.Price;
            }
            return mappedProductsList;
        }
    }
}
