using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.DAL.Entities
{
    public class BasketEntity
    {
        public int Id { get; set; }
        public virtual UserEntity User { get; set; }
        public string UserId { get; set; }
        public ICollection<ProductBasketEntity> ProductBasketEntities { get; set; }
    }
}
