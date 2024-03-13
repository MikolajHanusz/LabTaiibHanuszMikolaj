using Microsoft.EntityFrameworkCore;
using Model;
using System.Security.Cryptography.X509Certificates;

namespace DataAccessLayer
{
    public class WebShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BasketPosition> BasketPositions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebshopHanusz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x=>x.BasketPositions).WithOne(x=>x.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(x => x.Orders).WithOne(x => x.User).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>().HasMany(x => x.BasketPositions).WithOne(x => x.Product).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>().HasMany(x=>x.Positions).WithOne(x=>x.Order).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Order>().HasOne(x=>x.User).WithMany(x=>x.Orders).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderPosition>().HasOne(x => x.Order).WithMany(x => x.Positions).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().Property(x=>x.Type).HasConversion<int>();
        }
    }
}