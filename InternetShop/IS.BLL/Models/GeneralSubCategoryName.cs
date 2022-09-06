namespace IS.BLL.Models
{
    public class GeneralSubCategoryName
    {
        public int Id { get; set; }
#nullable disable
        public string Name { get; set; }
     //   public int SubCategoryId { get; set; }
#nullable enable
        public virtual IEnumerable<SubCategoryName> SubCategoriesName { get; set; }
    }
}
