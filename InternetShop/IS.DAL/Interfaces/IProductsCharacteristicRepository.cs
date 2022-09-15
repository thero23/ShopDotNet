using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IProductsCharacteristicRepository : IGenericRepository<ProductsCharacteristicEntity>
    {
        Task<IEnumerable<ProductsCharacteristicEntity>> GetProductById(IEnumerable<int> productsIds, CancellationToken ct);
    }
}
