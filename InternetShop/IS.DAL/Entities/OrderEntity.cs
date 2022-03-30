namespace IS.DAL.Entities
{
    public class OrderEntity
    {
#nullable disable
        public ICollection<OrderProductEntity> OrderProductEntities { get; set; }

        public virtual UserEntity User { get; set; }
        public string UserId { get; set; }

#nullable enable
        public int Id { get; set; }
        public int FinalPrice { get; set; }
    }
}
