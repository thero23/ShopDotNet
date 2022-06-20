using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductInOrderService: IGenericService<ProductInOrder>
    {
        Task<ProductInOrder> Post(ProductInOrder productInOrder, CancellationToken ct);
    }
}
