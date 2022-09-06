namespace IS.DAL.Entities
{
    public class GeneralSubCategoryNameEntity
    {
        public int Id { get; set; }
#nullable disable
        public string Name { get; set; }
     //   public int SubcategoryId { get; set; }

#nullable enable
       public ICollection<SubCategoryNameEntity> SubCategoriesName { get; set; }
    }
}
