using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
        Task<UserEntity> GetById(string id, CancellationToken ct);
    }
}
