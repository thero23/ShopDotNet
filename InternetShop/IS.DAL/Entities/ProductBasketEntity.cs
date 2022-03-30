namespace IS.DAL.Entities
{
    public class ProductBasketEntity
    {

#nullable disable
        public virtual ProductEntity Product { get; set; }
        public virtual BasketEntity Basket { get; set; }

        public int ProductId { get; set; }
        public int BasketId { get; set; }
#nullable enable
    }
}
