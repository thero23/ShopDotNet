using IS.BLL.Models;

namespace IS.BLL.Interfaces
{
    public interface IProductService : IGenericService<Product>
    {
        Task<IEnumerable<Product>> GetAll(string key, int value, CancellationToken ct);
        Task<IEnumerable<Product>> GetProductWithCategory(int categoryId, CancellationToken ct);
        Task<IEnumerable<Product>> GetProductsBySubCategory(int subCategoryId, CancellationToken ct);
    }
}
