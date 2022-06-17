using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IWhishListRepository : IGenericRepository<WhishListEntity>
    {
        ValueTask Delete(int userId, int productId, CancellationToken ct);
        Task<IEnumerable<WhishListEntity>> GetByUserId(int userId, CancellationToken ct);
    }
}
