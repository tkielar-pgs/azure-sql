using Microsoft.EntityFrameworkCore;

namespace PGS.Azure.Sql.Model
{
    public class AdventureWorksDbContext : DbContext
    {
        protected AdventureWorksDbContext()
        {
        }

        public AdventureWorksDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("SalesLT");

            modelBuilder.Entity<Customer>();
        }
    }
}