using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class OrderProductsRepository : GenericRepository<OrderProductEntity>, IOrderProductRepository
    {
        public OrderProductsRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task AddRange(IEnumerable<OrderProductEntity> orderProducts, CancellationToken ct)
        {
            await _dbSet.AddRangeAsync(orderProducts, ct);
            await _context.SaveChangesAsync(ct);
        }
    }
}
