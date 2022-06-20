using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class ProductInBasketRepository: GenericRepository<ProductInBasketEntity>, IProductInBasketRepository
    {
        public ProductInBasketRepository(DatabaseContext context) : base(context)
        {

        }

        public async Task<IEnumerable<ProductInBasketEntity>> GetById(int id, CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().Where(x => x.USerId == id).ToListAsync(ct);
        }

        public async Task<IEnumerable<ProductInBasketEntity>> Update(IEnumerable<ProductInBasketEntity> entities, CancellationToken ct)
        {
            _context.UpdateRange(entities);
            await _context.SaveChangesAsync(ct);
            return entities;
        }
    }
}