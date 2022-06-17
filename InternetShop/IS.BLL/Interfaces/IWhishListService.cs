using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IWhishListService : IGenericService<WhishList>
    {
        ValueTask Delete(int userId, int productId, CancellationToken ct);
        Task<IEnumerable<Product>> GetByUserId(int userId, CancellationToken ct);
    }
}
