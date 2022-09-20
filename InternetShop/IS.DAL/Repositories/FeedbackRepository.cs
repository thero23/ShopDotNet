using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class FeedbackRepository : GenericRepository<FeedbackEntity>, IFeedbackRepository
    {
        public FeedbackRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<FeedbackEntity>> GetFeedBacksByProduct(int productId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Include(x => x.Product).Include(x => x.User).Where(x => x.ProductId == productId).ToListAsync();
            return result;
        }
    }
}
