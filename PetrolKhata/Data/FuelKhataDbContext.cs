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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<FuelType>().ToTable("FuelTypes");
            modelBuilder.Entity<Sales>().ToTable("Sales");

            //modelBuilder.Entity<Sales>().HasOne<FuelType>().WithMany(x => x.Sales).HasForeignKey(x => x.FuelId);

            //modelBuilder.Entity<Sales>().HasOne<Customer>().WithMany(x => x.Sales).HasForeignKey(x => x.CustomerId) ;
        }
    }
}
