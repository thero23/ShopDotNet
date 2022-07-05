using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class ProductBasketRepository : GenericRepository<ProductBasketEntity>, IProductBasketRepository
    {
        public ProductBasketRepository(DatabaseContext context) : base(context)
        {
        }
        public Task DeleteProductsFromBasket(IEnumerable<ProductInBasketEntity> productInOrderEntities, CancellationToken ct)
        {
         //   _dbSet.RemoveRange(productInOrderEntities);
            return _context.SaveChangesAsync(ct);
        }

        public Task<ProductBasketEntity> GetByAuth0Id(string id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductInBasketEntity>> GetById(string id, CancellationToken ct)
        {
            
            return null;
        }

        public async Task<IEnumerable<ProductInBasketEntity>> Update(IEnumerable<ProductInBasketEntity> entities, CancellationToken ct)
        {
            _context.UpdateRange(entities);
            await _context.SaveChangesAsync(ct);
            return entities;
        }
    }
}
