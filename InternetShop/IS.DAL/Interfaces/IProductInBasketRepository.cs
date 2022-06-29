using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IProductInBasketRepository : IGenericRepository<ProductInBasketEntity>
    {
        Task<IEnumerable<ProductInBasketEntity>> GetById(string id, CancellationToken ct);
        Task<IEnumerable<ProductInBasketEntity>> Update(IEnumerable<ProductInBasketEntity> entities, CancellationToken ct);
        Task DeleteProductsFromBasket(IEnumerable<ProductInBasketEntity> productInOrderEntities, CancellationToken ct);
    }
}
