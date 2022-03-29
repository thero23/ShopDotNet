using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.DAL.Entities
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public int FinalPrice { get; set; }

        public ICollection<OrderProductEntity> OrderProductEntities { get; set; }

        public virtual UserEntity User { get; set; }
        public string UserId { get; set; }
    }
}
