using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class BasketRepository : GenericRepository<BasketEntity>, IBasketRepository
    {
        public BasketRepository(DatabaseContext context) : base(context)
        {
        }


        public async Task<BasketEntity> GetByAuth0Id(string id, CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == id, ct);
        }

        public async Task<BasketEntity> GetProductsBasketByUserId(string id, CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().Include(x => x.ProductBasketEntities).ThenInclude(x=> x.Product).FirstOrDefaultAsync(x => x.UserId == id, ct);
        }
    }
}
