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
    }
}
 