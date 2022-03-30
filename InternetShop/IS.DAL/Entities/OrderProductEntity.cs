namespace IS.DAL.Entities
{
    public class OrderProductEntity
    {
#nullable disable
        public virtual OrderEntity Order { get; set; }
        public virtual ProductEntity Product { get; set; }
#nullable enable
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
