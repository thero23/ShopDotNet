namespace IS.BLL.Models
{
    public class Basket
    {

#nullable disable
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<ProductBasket> ProductsBaskets { get; set; }

#nullable enable
    }
}
