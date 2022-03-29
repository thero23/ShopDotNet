using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.DAL.Entities
{
    public class OrderProductEntity
    {
        public int OrderId { get; set; }
        public virtual OrderEntity Order { get; set; }
        public int ProductId { get; set; }
        public virtual ProductEntity Product { get; set; }
    }
}
