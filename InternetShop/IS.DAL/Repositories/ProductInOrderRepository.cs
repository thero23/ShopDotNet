using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IS.DAL.Repositories
{
    public class ProductInOrderRepository : GenericRepository<ProductInOrderEntity>, IProductInOrderRepository
    {
        public ProductInOrderRepository(DatabaseContext context): base(context)
        {

        }

        public async Task<IEnumerable<ProductInOrderEntity>> AddRange(IEnumerable<ProductInOrderEntity> productInOrderEntities, CancellationToken ct)
        {
           // var test = productInOrderEntities.ToList();
            //test.ForEach(x =>
           // _context.Entry(x.UserData).State = EntityState.Unchanged);


            await _context.AddRangeAsync(productInOrderEntities, ct);
            await _context.SaveChangesAsync(ct);
            return productInOrderEntities;
        }
    }
}
