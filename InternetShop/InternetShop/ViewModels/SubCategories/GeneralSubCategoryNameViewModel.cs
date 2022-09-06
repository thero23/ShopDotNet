using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.SubCategories
{
    public class GeneralSubCategoryNameViewModel
    {
        public int Id { get; set; }
#nullable disable
        public string Name { get; set; }
       // public int SubCategoryId { get; set; }
        public virtual IEnumerable<SubCategoryNameViewModel> SubCategoriesName { get; set; }
#nullable enable
    }
}
