namespace IS.DAL.Entities
{
    public class OrderProductEntity
    {
#nullable disable
        public int OrderId { get; set; }
        public virtual OrderEntity Order { get; set; }
        public int ProductId { get; set; }
        public virtual ProductEntity Product { get; set; }
        public int Count { get; set; }

        public decimal Price { get; set; }
#nullable enable
    }
}
