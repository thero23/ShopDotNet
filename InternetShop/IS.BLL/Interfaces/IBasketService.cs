using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IBasketService : IGenericService<Basket>
    {
        Task<Basket> GetBasketByUserId(string id, CancellationToken ct);
     //   Task<IEnumerable<ProductInBasket>> Update(IEnumerable<ProductInBasket> productsInBaskets, CancellationToken ct);
    }
}
