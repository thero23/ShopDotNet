using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IS.DAL.Repositories
{
    public class SubCategoryRepository : GenericRepository<SubCategoryEntity>, ISubCategoryRepository
    {
        public SubCategoryRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SubCategoryEntity>> GetAllAsync(int id, CancellationToken ct)
        {
            var result = await _context.SubCategories.Where(x => x.CategoryId == id).Include(x => x.SubCategories).ThenInclude(x=> x.SubCategoriesName).ToListAsync(ct);
            return result;
        }
    }
}
