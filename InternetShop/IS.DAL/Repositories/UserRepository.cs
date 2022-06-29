using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<UserEntity> GetById(string id, CancellationToken ct)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Auth0Id == id, ct);
        }
    }
}
