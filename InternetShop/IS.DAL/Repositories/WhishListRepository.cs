using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class WhishListRepository : GenericRepository<WhishListEntity>, IWhishListRepository
    {
        public WhishListRepository(DatabaseContext context): base(context)
        {

        }

        public async ValueTask Delete(int userId, int productId, CancellationToken ct)
        {
            var entity = await _dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.ProductId == productId && x.UserId == userId, ct);
            if(entity is not null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync(ct);
            }
        }

        public async Task<IEnumerable<WhishListEntity>> GetByUserId(int userId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Where(x => x.UserId == userId).ToListAsync(ct);
            return result;
        }
    }
}
