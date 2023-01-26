using Microsoft.EntityFrameworkCore;
using MSDBackend.Model;

namespace MSDBackend.Infrastructure
{
    public class SmokingContext : DbContext
    {
        public DbSet<SmokeOccasion> smokeOccasions { get; set; }
        public DbSet<SmokeType> smokeTypes { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
            optionsBuilder.UseMySQL("Server=localhost;User=root;Password=;Database=smd");
        }
    }
}
