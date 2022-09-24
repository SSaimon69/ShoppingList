using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Models
{
    public class AppContext : DbContext
    {
        List<Purchase> purchases { get; set; } = null!;
        public AppContext(DbContextOptions options) :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
