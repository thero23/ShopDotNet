using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class UserDataRepository : GenericRepository<UserDataEntity>, IUserDataRepository
    {
        public UserDataRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<UserDataEntity> GetLastUserDataById(int userId, CancellationToken ct)
        {
          //  var result = _dbSet.AsNoTracking().OrderBy(x=> x.Id).LastOrDefault(x => x.UserId == userId);
           // return result;
            return null;
        }
    }
}
