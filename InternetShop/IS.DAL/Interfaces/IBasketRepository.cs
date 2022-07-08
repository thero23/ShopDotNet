using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IBasketRepository : IGenericRepository<BasketEntity>
    {
        Task<BasketEntity> GetByAuth0Id(string id, CancellationToken ct);
        Task<BasketEntity> GetProductsBasketByUserId(string id, CancellationToken ct);
    }
}
