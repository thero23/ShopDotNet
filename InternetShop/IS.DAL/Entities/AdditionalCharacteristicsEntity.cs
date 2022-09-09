namespace IS.DAL.Entities
{
    public class AdditionalCharacteristicsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ProductEntityId { get; set; }
    }
}
