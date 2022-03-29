using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IS.DAL.Entities
{
    public class UserEntity : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BasketEntity Basket { get; set; }
        public int BasketId { get; set; }

        public ICollection<OrderEntity> Orders { get; set; }
    }
}
