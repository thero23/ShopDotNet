using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductInBasketService : IGenericService<ProductInBasket>
    {
        Task<IEnumerable<ProductInBasket>> GetById(string id, CancellationToken ct);
        Task<IEnumerable<ProductInBasket>> Update(IEnumerable<ProductInBasket> productsInBaskets, CancellationToken ct);
    }
}
