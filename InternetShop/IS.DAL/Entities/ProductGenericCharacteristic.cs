namespace IS.DAL.Entities
{
    public class ProductGenericCharacteristic
    {
#nullable disable
        public int ProductId { get; set; }

        public virtual ProductEntity Products { get; set; }

        public Guid GenericCharacteristicId { get; set; }

        public virtual GenericCharacteristic GenericCharacteristics { get; set; }
    }
}
