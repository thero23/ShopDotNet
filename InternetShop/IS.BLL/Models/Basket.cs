namespace IS.BLL.Models
{
    public class Basket
    {

#nullable disable
        public string Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }

#nullable enable
        public ICollection<ProductBasket>? ProductsBaskets { get; set; }
    }
}
