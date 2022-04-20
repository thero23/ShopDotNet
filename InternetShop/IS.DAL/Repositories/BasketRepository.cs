using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IS.DAL.Repositories
{
    public class BasketRepository : GenericRepository<BasketEntity>, IBasketRepository
    {
        private readonly DatabaseContext _databaseContext;
        private readonly DbSet<BasketEntity> _dbSet;
        public BasketRepository(DatabaseContext context) : base(context)
        {
            _databaseContext = context;
            _dbSet = _databaseContext.Set<BasketEntity>();
        }

        public override IQueryable<BasketEntity> GetByCondition(Expression<Func<BasketEntity, bool>> expression)
        {
            var result = _dbSet.AsNoTracking().Where(expression).Include(x => x.ProductBasketEntities).ThenInclude(x => x.Product).AsQueryable();
            return result;
        }
    }
}
