namespace IS.BLL.Models
{
    public class ProductsCharacteristic
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CharacteristicsId { get; set; }
        public Characteristics Characteristics { get; set; }
    }
}
