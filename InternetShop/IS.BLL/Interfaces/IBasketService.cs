using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IBasketService
    {

        public Basket GetBasketWithProducts(string userId);
        public Task<Product> AddProductToBasketAsync(string userId, int productId, CancellationToken ct);
        public Task RemoveProductFromBasketAsync(string userId, int productId, CancellationToken ct);
        public Task ClearBasketAsync(string userId, CancellationToken ct);
        public Task DeleteBasketAsync(string userId, CancellationToken ct);

    }
}
