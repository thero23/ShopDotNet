using AutoMapper;
using IS.BLL.Interfaces;
using IS.BLL.Models;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;

namespace IS.BLL.Services
{
    public class ProductService : GenericService<Product, ProductEntity>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        private readonly IEnumerable<IStrategy> _strategy;
        public ProductService(
            IProductRepository repository,
            IMapper mapper, 
            IEnumerable<IStrategy> strategy) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _strategy = strategy;
        }

        public async Task<IEnumerable<Product>> GetAll(string key, int value, CancellationToken ct)
        {
            var expression = GetExpression(key, value);
            var products = _mapper.Map<IEnumerable<Product>>(await _repository.GetAll(expression, ct));
           // var products = await _repository.GetAll(ct);

            if (products.ToList().Count == 0) return products;

           // var mappedProductsList = _mapper.Map<IEnumerable<Product>>(products).ToList();


            foreach (var product in products)
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

            return products;
        }

        public async Task<IEnumerable<Product>> GetAll([FromQuery] Expression<Func<Product, bool>> expression, CancellationToken ct)
        {
            Expression<Func<ProductEntity, bool>> predicate = p => p.SubCategoryId == 2;
            var result = _mapper.Map<IEnumerable<Product>>(await _repository.GetAll(predicate, ct));
            //var result = _mapper.Map<IEnumerable<Product>>(await _repository.GetAll(_mapper.Map<Expression<Func<ProductEntity, bool>>>(predicate), ct));
            return result;
        }

        public override async Task<Product?> GetById(int id, CancellationToken ct)
        {
            var product = await _repository.GetById(id, ct);

            if (product == null) return null;

            var mappedProduct = _mapper.Map<Product>(product);
            mappedProduct.PriceWithDiscount = CalculatePriceWithDiscount(product.Price, product.Discount);
            return mappedProduct;
        }

        public async Task<IEnumerable<Product>> GetProductsBySubCategory(int subCategoryId, CancellationToken ct)
        {
            var products = await _repository.GetProductsBySubCategory(subCategoryId, ct);
            var mappedProducts = _mapper.Map<IEnumerable<Product>>(products);
            return mappedProducts;
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

        private Expression<Func<ProductEntity, bool>> GetExpression(string key, int value)
        {
            foreach (var strategy in _strategy)
            {
                if (strategy.IsValidStrategy(key, value))
                {
                    return strategy.Predicate(value);
                }
            }
            throw new ArgumentException();
        }
    }
}
