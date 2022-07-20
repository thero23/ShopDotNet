using IS.BLL.Models;
using System.Security.Claims;

namespace IS.BLL.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> Put(User user, CancellationToken ct);
        Task<User> GetById(string id, CancellationToken ct);
        Task<User> Add(User user, IEnumerable<Claim> claims, CancellationToken ct);

        Task Delete(string id, CancellationToken ct);
    }
}
