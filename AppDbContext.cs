using Microsoft.EntityFrameworkCore;
using SecondSiteArchitecture.Models;

namespace SecondSiteArchitecture.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Order> orders { get; set; } = null!;
        public DbSet<Category> categories { get; set; } = null!;
        public DbSet<Product> products { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        

    }
}
