namespace IS.BLL.Models
{
    public class ProviderCountry
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
#nullable enable
    }
}
