using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Purchase> Purchases { get; set; } = null!;
        public DbSet<Shop> Shops { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public AppContext(DbContextOptions options) :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
