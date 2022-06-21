using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IUserDataService : IGenericService<UserData>
    {
        Task<UserData> GetLastUserDataById(int userId, CancellationToken ct);
    }
}
