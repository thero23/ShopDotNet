using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IEqualsRepository : IGenericRepository<EqualsEntity>
    {
        Task<IEnumerable<EqualsEntity>> GetByUserId(string userId, CancellationToken ct);
    }
}
