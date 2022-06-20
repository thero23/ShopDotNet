using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class ProductInOrderRepository : GenericRepository<ProductInOrderEntity>, IProductInOrderRepository
    {
        public ProductInOrderRepository(DatabaseContext context): base(context)
        {

        }
    }
}
