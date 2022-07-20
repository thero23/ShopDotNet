using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IOrderRepository : IGenericRepository<OrderEntity>
    {
        Task<IEnumerable<OrderEntity>> AddRange(IEnumerable<OrderEntity> productInOrderEntities, CancellationToken ct);
        Task<IEnumerable<OrderEntity>> GetByUserId(string userId, CancellationToken ct);
        Task<OrderEntity> GetByOrderNumber(string orderNumber, CancellationToken ct);
    }
}
