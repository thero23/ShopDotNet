using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class ProductBasketRepository : GenericRepository<ProductBasketEntity>, IProductBasketRepository
    {
        public ProductBasketRepository(DatabaseContext context) : base(context)
        {
        }

        public async ValueTask Delete(ProductBasketEntity entity, CancellationToken ct)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync(ct);
        }

        public async Task DeleteProductsbasketRange(IEnumerable<ProductBasketEntity> entity, CancellationToken ct)
        {
            _dbSet.RemoveRange(entity);
            await _context.SaveChangesAsync(ct);
        }

        public Task<ProductBasketEntity> GetByAuth0Id(string id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductBasketEntity> GetByBasketIdAndProductId(string basketId, int productId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Include(x=> x.Basket).FirstOrDefaultAsync(x => x.BasketId == basketId && x.ProductId == productId, ct);
            return result;
        }

        public async Task<IEnumerable<ProductBasketEntity>> GetProductsByBasketId(string basketId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Include(x=> x.Product).Where(x => x.BasketId == basketId).ToListAsync(ct);
            return result;
        }

        public async Task<IEnumerable<ProductInBasketEntity>> Update(IEnumerable<ProductInBasketEntity> entities, CancellationToken ct)
        {
            _context.UpdateRange(entities);
            await _context.SaveChangesAsync(ct);
            return entities;
        }
    }
}
