﻿using System.Collections.Generic;
using IS.DAL.Entities;

namespace InternetShop.ViewModels.Product
{
    public class UpdateProductViewModel
    {
#nullable disable
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int QuantityInStock { get; set; }

        public int CurrencyId { get; set; }
        public int CategoryId { get; set; }
        public int ProviderCountryId { get; set; }
#nullable enable
        public int? Discount { get; set; }
    }
}
