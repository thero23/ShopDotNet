using Microsoft.AspNetCore.Identity;

namespace IS.DAL.Entities
{
    public class UserEntity : IdentityUser
    {
#nullable disable
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BasketEntity Basket { get; set; }

        public ICollection<OrderEntity> Orders { get; set; }
#nullable enable
        public int BasketId { get; set; }
    }
}
