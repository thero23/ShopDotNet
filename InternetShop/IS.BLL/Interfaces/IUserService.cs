using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> Put(User user, CancellationToken ct);
        Task<User> GetById(string id, CancellationToken ct);
    }
}
