using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class ProductBasketRepository : GenericRepository<ProductBasketEntity>, IProductBasketRepository
    {
        public ProductBasketRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
