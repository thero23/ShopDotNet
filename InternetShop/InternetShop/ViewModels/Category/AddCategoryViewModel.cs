using System.ComponentModel.DataAnnotations;

namespace InternetShop.API.ViewModels.Category
{
    public class AddCategoryViewModel
    {
#nullable disable
        [MinLength(5)]
        public string Name { get; set; }
#nullable enable
    }
}
