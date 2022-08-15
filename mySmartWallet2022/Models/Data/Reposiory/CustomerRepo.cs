using Microsoft.EntityFrameworkCore;
using mySmartWallet2022.Models.Data.Entities;
using mySmartWallet2022.Models.Data.Interface;

namespace mySmartWallet2022.Models.Data.Reposiory
{
    public class CustomerRepo : Repository<Customer, Guid>
    {

        public CustomerRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
