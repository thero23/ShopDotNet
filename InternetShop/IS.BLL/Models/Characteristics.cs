namespace IS.BLL.Models
{
    public class Characteristics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        public IEnumerable<AdditionalCharacteristics> AdditionalCharacteristics { get; set; }
    }
}
