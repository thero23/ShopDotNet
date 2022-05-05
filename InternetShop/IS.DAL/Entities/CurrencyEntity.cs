﻿namespace IS.DAL.Entities
{
    public class CurrencyEntity
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sign { get; set; }

      
#nullable enable
        public virtual ICollection<ProductEntity>? Products { get; set; }
    }
}
