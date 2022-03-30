namespace IS.DAL.Entities
{
    public class CategoryEntity
    {
#nullable disable
        public string Name { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
#nullable enable
        public int Id { get; set; }
      
    }
}
