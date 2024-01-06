using ecommerceAPI.Application.Abstraction;
using ecommerceAPI.Persistance.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ecommerceAPI.Persistance
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
