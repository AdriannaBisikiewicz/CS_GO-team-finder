using CS_GO.Configurations;
using CS_GO.Domain.Model;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace CS_GO.DataAccess
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}