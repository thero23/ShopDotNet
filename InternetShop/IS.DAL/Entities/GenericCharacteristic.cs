namespace IS.DAL.Entities
{
    public class GenericCharacteristic
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<ProductGenericCharacteristic>? ProductGenericCharacteristics { get; set; }

        public string DetailsCharacteristicId { get; set; }

        public ICollection<DetailsCharacteristic> ? DetailsCharacteristics { get; set; }
    }
}
