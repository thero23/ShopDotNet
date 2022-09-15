namespace IS.BLL.Models
{
    public class Equals
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ProductsCharacteristic Characteristics { get; set; }
    }
}
