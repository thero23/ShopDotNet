using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductBasketService: IGenericService<ProductBasket>
    {
        Task<IEnumerable<ProductBasket>> AddProductToBasket(string id, CancellationToken ct);
    }
}
