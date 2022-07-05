using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IBasketRepository : IGenericRepository<BasketEntity>
    {
        Task<BasketEntity> GetByAuth0Id(string id, CancellationToken ct);
        //    Task<IEnumerable<ProductInBasketEntity>> GetById(string id, CancellationToken ct);
        //   Task<IEnumerable<ProductInBasketEntity>> Update(IEnumerable<ProductInBasketEntity> entities, CancellationToken ct);
        //  Task DeleteProductsFromBasket(IEnumerable<ProductInBasketEntity> productInOrderEntities, CancellationToken ct);

    }
}
