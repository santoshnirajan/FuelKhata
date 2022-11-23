using Microsoft.EntityFrameworkCore;
using PetrolKhata.Model;

namespace PetrolKhata.Data
{
    public class FuelKhataDbContext : DbContext
    {
        public FuelKhataDbContext(DbContextOptions<FuelKhataDbContext> options) : base(options)
        {
        }
        DbSet<Customer> Customers { get; set; }
        DbSet<FuelType> FuelTypes { get; set; }
        DbSet<Sales> Sale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasOne<FuelType>().WithMany(x => x.Customers).HasForeignKey(x => x.FuelId);
            modelBuilder.Entity<Sales>().HasOne<FuelType>().WithMany(x => x.Sales).HasForeignKey(x => x.FuelId).
                OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Sales>().HasOne<Customer>().WithMany(x => x.Sales).HasForeignKey(x => x.CustomerId).
                OnDelete(DeleteBehavior.ClientSetNull); ;
        }
    }
}
