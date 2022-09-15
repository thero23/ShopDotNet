namespace IS.DAL.Entities
{
    public class CharacteristicsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<AdditionalCharacteristicsEntity> AdditionalCharacteristics { get; set; }
        public virtual ICollection<ProductsCharacteristicEntity> ProductsCharacteristics { get; set; }
    }
}
