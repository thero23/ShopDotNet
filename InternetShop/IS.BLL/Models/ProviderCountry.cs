namespace IS.BLL.Models
{
    public class ProviderCountry
    {
#nullable disable
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public virtual Basket Basket { get; set; }
        public int BasketId { get; set; }
#nullable enable
    }
}
