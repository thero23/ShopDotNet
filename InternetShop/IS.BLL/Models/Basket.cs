namespace IS.BLL.Models
{
    public class Basket
    {

#nullable disable
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<ProductBasket> ProductBasketEntities { get; set; }

#nullable enable
    }
}
