using IS.DAL.Entities;
using System.Linq.Expressions;

namespace IS.BLL.Interfaces
{
    public interface IStrategy
    {
        Expression<Func<ProductEntity, bool>> Predicate(int value);
        bool IsValidStrategy(string key, int value);
    }
}
