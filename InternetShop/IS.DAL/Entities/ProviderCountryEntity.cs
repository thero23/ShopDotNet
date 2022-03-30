namespace IS.DAL.Entities
{
    public class ProviderCountryEntity
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
#nullable enable
       
    }
}
