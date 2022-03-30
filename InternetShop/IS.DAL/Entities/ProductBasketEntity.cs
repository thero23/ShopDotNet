namespace IS.DAL.Entities
{
    public class ProductBasketEntity
    {

#nullable disable
        public virtual ProductEntity Product { get; set; }
        public virtual BasketEntity Basket { get; set; }
#nullable enable
        public int ProductId { get; set; }
        public int BasketId { get; set; }
    }
}
