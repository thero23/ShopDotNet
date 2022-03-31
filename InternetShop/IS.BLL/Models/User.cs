using Microsoft.AspNetCore.Identity;

namespace IS.BLL.Models
{
    public class User: IdentityUser
    {
#nullable disable
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }
#nullable enable
        public int? BasketId { get; set; }
        public Basket? Basket { get; set; }
    }
}
