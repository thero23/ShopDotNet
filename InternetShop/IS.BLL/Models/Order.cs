namespace IS.BLL.Models
{
    public class Order
    {
#nullable disable
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual User User { get; set; }
        public string UserId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreatedAt { get; set; }

#nullable enable
        public ICollection<OrderProduct>? OrderProduct { get; set; }
    }
}
