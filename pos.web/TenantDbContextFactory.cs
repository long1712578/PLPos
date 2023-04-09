using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using pos.data;

namespace pos.web
{
    public class TenantDbContextFactory : IDesignTimeDbContextFactory<TenantDbContext>
    {
        public TenantDbContext CreateDbContext(string[] args)
        {
            var configurationBuider = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json", optional: true);
            var configuration = configurationBuider.Build();
            var connectionString = configuration.GetConnectionString("TenantConnection");

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<TenantDbContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionString);
            return new TenantDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
