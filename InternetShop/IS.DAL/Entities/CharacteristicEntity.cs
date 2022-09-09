namespace IS.DAL.Entities
{
    public class CharacteristicsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ProductEntityId { get; set; }
        public IEnumerable<AdditionalCharacteristicsEntity> AdditionalCharacteristics { get; set; }
    }
}
