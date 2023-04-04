using Microsoft.EntityFrameworkCore;
using pos.data;

namespace pos.products.Services
{
    public interface IProductService
    {

    }
    public class ProductService: IProductService
    {
        private readonly ITenantDbContextFactory _tenantDbContextFactory;
        public ProductService(ITenantDbContextFactory tenantDbContextFactory)
        {
            _tenantDbContextFactory = tenantDbContextFactory;
        }
    }
}