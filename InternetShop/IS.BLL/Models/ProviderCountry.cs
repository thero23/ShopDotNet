using System.Text.Json.Serialization;

namespace IS.BLL.Models
{
    [Serializable]
    public class ProviderCountry
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }

#nullable enable
        public ICollection<Product>? Products { get; set; }
    }
}
