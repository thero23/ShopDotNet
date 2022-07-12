using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IOrderProductRepository
    {
        Task AddRange(IEnumerable<OrderProductEntity> orderProducts, CancellationToken ct); 
    }
}
