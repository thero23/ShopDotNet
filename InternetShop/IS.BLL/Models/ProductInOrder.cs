namespace IS.BLL.Models
{
    public class ProductInOrder
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        public User? UserData { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}