using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.data
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDataService(this IServiceCollection services,
            string connectionString, bool sensitiveDataLogging, bool detailError)
        {
            return services
                .AddTenantContext(connectionString, sensitiveDataLogging, detailError)
                .AddScoped<ITenantDbContextFactory, TenantDbContextFactory>();
        }

        private static IServiceCollection AddTenantContext(this IServiceCollection services, 
            string connectionString, bool sensitiveDataLogging, bool detailError)
        {
            return services
                .AddDbContextFactory<TenantDbContext>(builder =>
                {
                    builder
                    .UseSqlServer(connectionString)
                    .EnableSensitiveDataLogging(sensitiveDataLogging)
                    .EnableDetailedErrors(detailError)
#if DEBUG
                    .LogTo(s => System.Diagnostics.Debug.WriteLine(s));
#endif

                });
        }
    }
}
