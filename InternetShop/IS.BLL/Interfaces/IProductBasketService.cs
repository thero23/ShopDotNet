using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductBasketService: IGenericService<ProductBasket>
    {
        Task<ProductBasket> AddProductToBasket(string userId, int productId, CancellationToken ct);
        ValueTask Delete(string basketId, int productId, CancellationToken ct);
        Task<ProductBasket> UpdateCountProductsInBasket(ProductBasket basket, CancellationToken ct);

    }
}
