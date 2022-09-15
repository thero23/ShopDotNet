using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductCharacteristicService : IGenericService<ProductsCharacteristic>
    {
        Task<IEnumerable<ProductsCharacteristic>> GetCharacteristicByProduct(IEnumerable<int> productIds, CancellationToken ct);
    }
}
