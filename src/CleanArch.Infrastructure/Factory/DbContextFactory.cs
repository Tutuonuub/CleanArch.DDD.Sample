using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using CleanArch.Infrastructure.Data;

namespace CleanArch.Infrastructure.Factory
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CleanArchSample;Trusted_Connection=True;TrustServerCertificate=True;");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
