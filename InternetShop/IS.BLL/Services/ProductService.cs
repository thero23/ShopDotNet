using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.BLL.Services
{
    public class ProductService : GenericService<Product, ProductEntity>, IProductService
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

            if (products.ToList().Count == 0) return new List<Product>();

            var mappedProductsList = _mapper.Map<IEnumerable<Product>>(products).ToList();


            foreach (var product in mappedProductsList)
            {
                product.PriceWithDiscount = CalculatePriceWithDiscount(product.Price, product.Discount);
            }

            //string json = JsonConvert.SerializeObject(mappedProductsList, new JsonSerializerSettings
            //{
            //  //  ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //});

            //using (StreamWriter writer = new("products.json", true, System.Text.Encoding.Default))
            //{
            //    await writer.WriteAsync(json);
            //}

            return mappedProductsList;
        }

        public override async Task<Product?> GetById(int id, CancellationToken ct)
        {
            var product = await _repository.GetById(id, ct);

            if (product == null) return null;

            var mappedProduct = _mapper.Map<Product>(product);
            mappedProduct.PriceWithDiscount = CalculatePriceWithDiscount(product.Price, product.Discount);
            return mappedProduct;
        }

        public async Task<IEnumerable<Product>> GetProductWithCategory(int categoryId, CancellationToken ct)
        {
            var products = await _repository.GetProductWithCategory(categoryId, ct);
            var mappedProductsList = _mapper.Map<IEnumerable<Product>>(products).ToList();
            return mappedProductsList;
        }

        private decimal CalculatePriceWithDiscount(decimal price, int discount)
        {
            return (decimal)(100 - discount) / 100 * price;
        }
    }
}
