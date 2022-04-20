using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace IS.DAL.Repositories
{
    public class BasketRepository : GenericRepository<BasketEntity>, IBasketRepository
    {
        
        public BasketRepository(DatabaseContext context) : base(context)
        {
         //   _databaseContext = context;
          //  _dbSet = _databaseContext.Set<BasketEntity>();
        }

        public async Task<BasketEntity> GetByCondition(string id)
        {
            var result = _dbSet.AsNoTracking().Include(x => x.ProductBasketEntities).ThenInclude(x => x.Product).FirstOrDefaultAsync(x => x.UserId == id);
            return await result;
            //  var result = await _dbSet.AsNoTracking().Include(x => x.ProductBasketEntities).ThenInclude(x => x.Product).ToListAsync();
            var tets = await _dbSet.AsNoTracking().Include(x => x.ProductBasketEntities).ToListAsync();
            var test2 = await _dbSet.AsNoTracking().Include(x => x.ProductBasketEntities).ThenInclude(x => x.Product).ToListAsync();
           // return null;
        }
    }
}
