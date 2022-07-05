using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class ProductInBasketRepository: GenericRepository<ProductBasketEntity>
    {
        public ProductInBasketRepository(DatabaseContext context) : base(context)
        {

        }

       /* public Task DeleteProductsFromBasket(IEnumerable<ProductInBasketEntity> productInOrderEntities, CancellationToken ct)
        {
            _dbSet.RemoveRange(productInOrderEntities);
               return _context.SaveChangesAsync(ct);
        }

        public async Task<IEnumerable<ProductInBasketEntity>> GetById(string id, CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().Where(x => x.UserId == id).ToListAsync(ct);
        }

        public async Task<IEnumerable<ProductInBasketEntity>> Update(IEnumerable<ProductInBasketEntity> entities, CancellationToken ct)
        {
            _context.UpdateRange(entities);
            await _context.SaveChangesAsync(ct);
            return entities;
        }*/
    }
}