namespace IS.DAL.Entities
{
    public class ProductInOrderEntity
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductEntityId { get; set; }
        public virtual ProductEntity ProductEntity { get; set; }
        public int Count { get; set; }
        public string UserId { get; set; }
    }
}
