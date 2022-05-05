using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.BLL.Models
{
    public class ProductForBasket
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public int QuantityInBasket { get; set; }
        public virtual Currency Currency { get; set; }
        public int Price { get; set; }
        public int PriceWithDiscount { get; set; }
        public int Discount { get; set; }
#nullable enable
    }
}
