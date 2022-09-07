using IS.BLL.Interfaces;
using IS.DAL.Entities;
using System.Linq.Expressions;

namespace IS.BLL.Services
{
    public class GetAllProductsStrategy : IStrategy
    {
        public bool IsValidStrategy(string key, int value)
        {
            return key.Equals("getAll") && value == 0;
        }

        public Expression<Func<ProductEntity, bool>> Predicate(int value)
        {
            Expression<Func<ProductEntity, bool>> expression = p => true;
            return expression;
        }
    }
}
