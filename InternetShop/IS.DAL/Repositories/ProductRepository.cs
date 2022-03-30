using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class ProductRepository: GenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
