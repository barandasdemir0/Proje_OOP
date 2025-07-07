using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BARANPC\\SQLEXPRESS;Database=DbNewOopCore;integrated security=True; TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; } // Product C#daki hali products ise veritabanındaki tablo adı
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
