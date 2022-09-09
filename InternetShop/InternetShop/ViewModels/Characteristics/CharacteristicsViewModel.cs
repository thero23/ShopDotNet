using InternetShop.Api.ViewModels.Characteristics.AdditionalCharacteristics;
using System.Collections.Generic;

namespace InternetShop.Api.ViewModels.Characteristics
{
    public class CharacteristicsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ProducEntitytId { get; set; }
        public IEnumerable<AdditionalCharacteristicsViewModel> AdditionalCharacteristics { get; set; }
    }
}
