using Microsoft.EntityFrameworkCore;
using SimpleShop.ApplicationCore.Entities;

namespace SimpleShop.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(prop => prop.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}