using mySmartWallet2022.Models.Data.Entities;

namespace mySmartWallet2022.Models.Data
{
    public class SeedHelperClass
    {
        public static async Task seed(ApplicationDbContext context)
        {
            if (!context.Customers.Any())
            {

                context.Customers.Add(new Customer

                {
                    FirstName = "Ismail",
                    LastName = "Adekambi",
                    MiddleName = "Oladimeji",
                    gender = GenderEnum.male,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Country = "England",
                    State = "London",
                    City = "Manhattan",
                    Active = true,

                });
                context.Customers.Add(new Customer

                {
                    FirstName = "Clara",
                    LastName = "Adekambi",
                    MiddleName = "Amirah",
                    gender = GenderEnum.Female,
                    MaritalStatus = MaritalStatusEnum.Single,
                    DateOfBirth = DateTime.Now.AddYears(-10),
                    Country = "England",
                    State = "London",
                    City = "Manhattan",
                    Active = true,

                }
                    );
                // context.SaveChangesAsync();
                await context.SaveChangesAsync();
            }

        }
    }
}
