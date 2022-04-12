using IS.DAL.Contexts;
using IS.DAL.Contexts.Configurations;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace IS.DAL.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly MongoDbContext _mongoDbContext;

        public ProductRepository(IOptions<Settings> settings)
        {
            _mongoDbContext = new MongoDbContext(settings);
        }

        public Task<ProductEntity> Add(ProductEntity entity, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public ValueTask Delete(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductEntity>> GetAll(CancellationToken ct)
        {
            var products = await _mongoDbContext.Products.FindAsync(x => x.Id == 1);

            return await products.ToListAsync(ct);
        }

        public async Task<IEnumerable<ProductEntity>> GetAllAsync(CancellationToken ct)
        {
            var products = await _mongoDbContext.Products.FindAsync(x=> x.Id == 1);
           
            return await products.ToListAsync(ct);
        }

        public Task<ProductEntity?> GetById(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> Update(ProductEntity entity, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
