namespace IS.BLL.Models
{
    [Serializable]
    public class Currency
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sign { get; set; }
#nullable enable
        public ICollection<Product>? Products { get; set; }
    }
}
