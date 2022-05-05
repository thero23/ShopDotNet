namespace IS.DAL.Entities
{
    public class CategoryEntity
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }

#nullable enable
        public virtual ICollection<ProductEntity>? Products { get; set; }
    }
}
