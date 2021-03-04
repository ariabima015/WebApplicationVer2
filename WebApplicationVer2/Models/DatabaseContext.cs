using Microsoft.EntityFrameworkCore;

namespace WebApplicationVer2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>()
                .HasOne(b => b.Group)
                .WithMany(a => a.Warehouses)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
