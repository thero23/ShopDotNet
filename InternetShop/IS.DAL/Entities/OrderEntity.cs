namespace IS.DAL.Entities
{
    public class OrderEntity
    {
#nullable disable
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual UserEntity User { get; set; }
        public string UserId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreatedAt { get; set; }

#nullable enable
        public ICollection<OrderProductEntity>? OrderProductEntities { get; set; }
    }
}
