using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface ISubCategoryService : IGenericService<SubCategory>
    {
        Task<IEnumerable<SubCategory>> GetAll(int id, CancellationToken ct);
    }
}
