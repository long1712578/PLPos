using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.data
{
    public interface ITenantDbContextFactory : IDbContextFactory<TenantDbContext>
    {
    }
    public class TenantDbContextFactory : ITenantDbContextFactory
    {
        private readonly DbContextOptions<TenantDbContext> _options;

        public TenantDbContextFactory(DbContextOptions<TenantDbContext> options)
        {
            _options = options;
        }

        public TenantDbContext CreateDbContext()
        {
            var db = new TenantDbContext(_options);
            return db;
        }
    }
}
