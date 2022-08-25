namespace IS.BLL.Models
{
    [Serializable]
    public class ProductBasket
    {
#nullable disable
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public string BasketId { get; set; }
        public virtual Basket Basket { get; set; }

        public int Count { get; set; }
#nullable enable
    }
}
