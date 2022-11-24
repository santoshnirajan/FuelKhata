using Microsoft.EntityFrameworkCore;
using PetrolKhata.Model;

namespace PetrolKhata.Data
{
    public class FuelKhataDbContext : DbContext
    {
        public FuelKhataDbContext(DbContextOptions<FuelKhataDbContext> options) : base(options)
        {
        }
       public  DbSet<Customer> Customers { get; set; }
       public  DbSet<FuelType> FuelTypes { get; set; }
       public  DbSet<Sales> Sale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sales>().HasOne<FuelType>().WithMany(x => x.Sales).HasForeignKey(x => x.FuelId);

            modelBuilder.Entity<Sales>().HasOne<Customer>().WithMany(x => x.Sales).HasForeignKey(x => x.CustomerId) ;
        }
    }
}
