using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IOrderService: IGenericService<Order>
    {
        Task<Order> Post(User userData, CancellationToken ct);
        Task<IEnumerable<Order>> GetByUserId(string id, CancellationToken ct);
        Task DeleteByOrderNumber(string id, CancellationToken ct);
        Task<Order> GetByOrderNumber(string orderNumber, CancellationToken ct);
    }
}
