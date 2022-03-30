namespace IS.DAL.Entities
{
    public class CategoryEntity
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }

#nullable enable
        public ICollection<ProductEntity>? Products { get; set; }
    }
}
