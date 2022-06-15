using Microsoft.EntityFrameworkCore;
using RYT645.Entities;
using Unipluss.Sign.ExternalContract.Entities;

namespace RYT645.Data.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
