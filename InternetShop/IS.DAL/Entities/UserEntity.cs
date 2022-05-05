using Microsoft.AspNetCore.Identity;

namespace IS.DAL.Entities
{
    public class UserEntity : IdentityUser
    {
#nullable disable
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<OrderEntity> Orders { get; set; }
#nullable enable
        public int? BasketId { get; set; }
        public virtual BasketEntity? Basket { get; set; }
    }
}
