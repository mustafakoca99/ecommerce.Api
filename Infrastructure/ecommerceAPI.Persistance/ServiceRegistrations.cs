using ecommerceAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ecommerceAPI.Persistance
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EcommerceAPIDbContext>(options =>
                options.UseSqlServer(
                    "server=(localdb)\\kmssqllocaldb;database=ecommerce;user=sa;password=M.k12345"
                    ));
        }
    }
}
