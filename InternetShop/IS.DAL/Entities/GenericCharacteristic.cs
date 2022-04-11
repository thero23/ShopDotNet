namespace IS.DAL.Entities
{
    public class GenericCharacteristic
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<ProductGenericCharacteristic>? ProductGenericCharacteristics { get; set; }
    }
}
