using IS.BLL.Interfaces;
using IS.DAL.Entities;
using System.Linq.Expressions;

namespace IS.BLL.Services
{
    internal class GetProductsByCategoryStrategy : IStrategy
    {
        public bool IsValidStrategy(string key, int value)
        {
            return key.Equals("categoryId") && value != 0;
        }

        public Expression<Func<ProductEntity, bool>> Predicate(int value)
        {
            Expression<Func<ProductEntity, bool>> expression = p => p.CategoryId == value;
            return expression;
        }
    }
}
