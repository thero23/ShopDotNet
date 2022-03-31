namespace IS.DAL.Entities
{
    public class OrderEntity
    {
#nullable disable
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public virtual UserEntity User { get; set; }
        public string UserId { get; set; }

#nullable enable
        public ICollection<OrderProductEntity>? OrderProductEntities { get; set; }
    }
}
