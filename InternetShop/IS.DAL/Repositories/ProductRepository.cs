using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class ProductRepository: GenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductEntity>> GetProductFromwhishList(IEnumerable<int> ids, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().Where(x => ids.Contains(x.Id)).ToListAsync(ct);
            return result;
        }

        public async Task<IEnumerable<ProductEntity>> GetProductWithCategory(int categoryId, CancellationToken ct)
        {
            var result = await _dbSet.AsNoTracking().ToListAsync(ct);
            result = result.Where(x => x.CategoryId == categoryId).ToList();
            return result;
        }
    }
}
