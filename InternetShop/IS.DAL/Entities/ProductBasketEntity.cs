using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.DAL.Entities
{
    public class ProductBasketEntity
    {
        public int ProductId { get; set; }
        public virtual ProductEntity Product { get; set; }
        public int BasketId { get; set; }
        public virtual BasketEntity Basket { get; set; }
    }
}
