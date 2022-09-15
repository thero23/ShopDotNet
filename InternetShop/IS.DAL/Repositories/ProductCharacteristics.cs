using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class ProductCharacteristicsRepository : GenericRepository<ProductsCharacteristicEntity>, IProductsCharacteristicRepository
    {
        public ProductCharacteristicsRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductsCharacteristicEntity>> GetProductById(IEnumerable<int> productsIds, CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().Where(x=> productsIds.Contains(x.ProductId)).Include(x=> x.Characteristics).ThenInclude(x=> x.AdditionalCharacteristics).ToListAsync(ct);
        }
    }
}
