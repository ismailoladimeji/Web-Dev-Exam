using Microsoft.EntityFrameworkCore;
using mySmartWallet2022.Models.Data.Entities;

namespace mySmartWallet2022.Models.Configuration
{
    public class customerConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("First_Name");
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.gender).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Country).IsRequired(true);
            modelBuilder.Entity<Customer>().Property(c => c.City).IsRequired(true);

            //modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique(true);
            //modelBuilder.Entity<Customer>().HasIndex(c => c.PhoneNo).IsUnique(true);

            return modelBuilder;

        }
    }
}
