using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class OrderRepository : GenericRepository<OrderEntity>, IOrderRepository
    {
        public OrderRepository(DatabaseContext context) : base(context)
        {

        }
        public async Task<IEnumerable<OrderEntity>> AddRange(IEnumerable<OrderEntity> productInOrderEntities, CancellationToken ct)
        {
            await _context.AddRangeAsync(productInOrderEntities, ct);
            await _context.SaveChangesAsync(ct);
            return productInOrderEntities;
        }

        public async Task<OrderEntity> GetByOrderNumber(string orderNumber, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Include(x => x.OrderProductEntities).ThenInclude(x => x.Product).FirstOrDefaultAsync(x => x.OrderNumber == orderNumber, ct);
            return result;
        }

        public async Task<IEnumerable<OrderEntity>> GetByUserId(string userId, CancellationToken ct)
        {
            var result = await _dbSet.Where(x => x.UserId == userId).Include(x => x.OrderProductEntities).ThenInclude(x => x.Product).ToListAsync(ct);
            return result;
        }
    }
}
