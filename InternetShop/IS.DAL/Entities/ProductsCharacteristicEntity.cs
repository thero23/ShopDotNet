namespace IS.DAL.Entities
{
    public class ProductsCharacteristicEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }

        public int CharacteristicsId { get; set; }
        public CharacteristicsEntity Characteristics { get; set; }
    }
}
