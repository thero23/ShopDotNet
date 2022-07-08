using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IProductBasketRepository: IGenericRepository<ProductBasketEntity>
    {
        Task<ProductBasketEntity> GetByBasketIdAndProductId (string basketId, int productId, CancellationToken ct);
        ValueTask Delete(ProductBasketEntity entity, CancellationToken ct);
    }
}
