using IS.DAL.Contexts;
using IS.DAL.Entities;
using IS.DAL.Interfaces;

namespace IS.DAL.Repositories
{
    public class SubCategoryRepository : GenericRepository<SubCategoryEntity>, ISubCategoryRepository
    {
        public SubCategoryRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
