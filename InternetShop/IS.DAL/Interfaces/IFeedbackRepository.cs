using IS.DAL.Entities;

namespace IS.DAL.Interfaces
{
    public interface IFeedbackRepository : IGenericRepository<FeedbackEntity>
    {
        Task<IEnumerable<FeedbackEntity>> GetFeedBacksByProduct(int productId, CancellationToken ct);
    }
}
