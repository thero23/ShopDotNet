namespace IS.BLL.Models
{
    public class ProductBasket
    {
#nullable disable
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int BasketId { get; set; }
        public virtual Basket Basket { get; set; }
#nullable enable
    }
}
