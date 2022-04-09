using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.DAL.Entities
{
    public class ProductGenericCharacteristic
    {
        public int Id { get; set; }
        public int ProductssId { get; set; }
        public int GenericCharacteristicId { get; set; } 
    }
}
