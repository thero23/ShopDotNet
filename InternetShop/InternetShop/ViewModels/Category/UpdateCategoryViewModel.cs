using System.ComponentModel.DataAnnotations;

namespace InternetShop.ViewModels.Category
{
    public class UpdateCategoryViewModel
    {
        [MinLength(5)]
        public string Name { get; set; }
    }
}
