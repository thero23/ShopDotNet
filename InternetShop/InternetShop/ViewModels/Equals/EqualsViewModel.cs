using InternetShop.Api.ViewModels.Characteristics.AdditionalCharacteristics;
using InternetShop.API.ViewModels.Product;
using System.Collections;
using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.Equals
{
    public class EqualsViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public virtual ProductViewModel Product { get; set; }
    }

    public class MyCharacteristics
    {
        public string Name { get; set; }
        public IEnumerable<AdditionalCharacteristicsViewModel> AdditionalCharacteristics { get; set; }
    }
}
