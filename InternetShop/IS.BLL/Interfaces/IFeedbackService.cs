using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IFeedbackService : IGenericService<Feedback>
    {
        Task<IEnumerable<Feedback>> GetFeedBacksByProduct(int productId, CancellationToken ct);
    }
}
