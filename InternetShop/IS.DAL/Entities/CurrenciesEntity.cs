using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.DAL.Entities
{
    public class CurrenciesEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sign { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}
