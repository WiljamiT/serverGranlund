using Microsoft.EntityFrameworkCore;
using LocationApi.Models;

namespace LocationApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; }
    }
}
