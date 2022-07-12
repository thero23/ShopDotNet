using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IBasketRepository : IGenericRepository<BasketEntity>
    {
        Task<BasketEntity> GetByUserId (string userId, CancellationToken ct);
        Task<BasketEntity> GetProductsBasketByUserId(string id, CancellationToken ct);
    }
}
