using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IUserDataRepository : IGenericRepository<UserDataEntity>
    {
        Task<UserDataEntity> GetLastUserDataById(int userId, CancellationToken ct);
    }
}
