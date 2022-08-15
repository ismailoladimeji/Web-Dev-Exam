namespace mySmartWallet2022.Models.Data.Entities
{
    public abstract class baseClass // this class can only be inherited from; it can not be instantiated
    {
        public Guid Id { set; get; }
    }
}
