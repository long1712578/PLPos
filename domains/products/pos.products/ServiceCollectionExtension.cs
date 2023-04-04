using Microsoft.Extensions.DependencyInjection;
using pos.products.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.products
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddProductService(this IServiceCollection services)
        {
            return services.AddScoped<IProductService, ProductService>();
        }
    }
}
