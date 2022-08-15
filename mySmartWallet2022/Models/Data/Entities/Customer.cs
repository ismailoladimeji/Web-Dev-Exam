namespace mySmartWallet2022.Models.Data.Entities
{
    public class Customer :  BaseClass2<Guid>
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public GenderEnum gender { set; get; }
        public MaritalStatusEnum MaritalStatus { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Country { set; get; }
        public string State { set; get; }

        public DateTime RegisterationDate { set; get; }
        public string City { set; get; }
        public bool Active { set; get; }



    }
}
