using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Purchase> purchases { get; set; } = null!;
        public DbSet<Shop> shops { get; set; } = null!;
        public DbSet<Category> categories { get; set; } = null!;
        public DbSet<Product> products { get; set; } = null!;
        public AppContext(DbContextOptions options) :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
