using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IEqualsService : IGenericService<Equals>
    {
        Task<IEnumerable<Product>> GetByUserId(string authId, CancellationToken ct);
    }
}
