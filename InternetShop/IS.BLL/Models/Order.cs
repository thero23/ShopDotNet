namespace IS.BLL.Models
{
    public class Order
    {
#nullable disable
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public virtual User User { get; set; }
        public string UserId { get; set; }
#nullable enable
        public ICollection<OrderProduct>? OrdersProducts { get; set; }
    }
}
