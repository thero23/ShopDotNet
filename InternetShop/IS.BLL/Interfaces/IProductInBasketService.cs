using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductInBasketService : IGenericService<ProductInBasket>
    {
        Task<IEnumerable<ProductInBasket>> GetById(int id, CancellationToken ct);
    }
}
