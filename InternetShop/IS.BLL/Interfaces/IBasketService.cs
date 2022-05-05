using IS.BLL.Models;
using IS.DAL.Entities;

namespace IS.BLL.Interfaces
{
    public interface IBasketService
    {

        public Basket GetBasketWithProducts(string userId, CancellationToken ct);
        public Task<Product> AddProductToBasketAsync(string userId, int productId,int quantity, CancellationToken ct);
        public Task RemoveProductFromBasketAsync(string userId, int productId, CancellationToken ct);
        public Task ClearBasketAsync(string userId, CancellationToken ct);
        public Task DeleteBasketAsync(string userId, CancellationToken ct);

    }
}
