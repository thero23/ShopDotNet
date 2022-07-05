using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class BasketRepository : GenericRepository<BasketEntity>, IBasketRepository
    {
        public BasketRepository(DatabaseContext context) : base(context)
        {
        }

        public int GetByAuth0Id(string id, CancellationToken ct)
        {
            var result = _dbSet.AsNoTracking().FirstOrDefaultAsync(x=> x.User.Auth0Id == id, ct).Id;
            return result;
        }

        Task<BasketEntity> IBasketRepository.GetByAuth0Id(string id, CancellationToken ct)
        {
            //return _dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, ct);
            return null;
        }
    }
}
