using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IProductInOrderRepository : IGenericRepository<ProductInOrderEntity>
    {
        Task<IEnumerable<ProductInOrderEntity>> AddRange(IEnumerable<ProductInOrderEntity> productInOrderEntities, CancellationToken ct);
    }
}
