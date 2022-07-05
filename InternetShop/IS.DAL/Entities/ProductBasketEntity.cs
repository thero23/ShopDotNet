namespace IS.DAL.Entities
{
    public class ProductBasketEntity
    {
#nullable disable
        public int ProductId { get; set; }
        public virtual ProductEntity Product { get; set; }

        public string BasketId { get; set; }
        public virtual BasketEntity Basket { get; set; }
        public int Count { get; set; }
#nullable enable
    }
}
