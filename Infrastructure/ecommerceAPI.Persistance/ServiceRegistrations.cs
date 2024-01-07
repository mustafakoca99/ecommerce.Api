using ecommerceAPI.Application.Repositories;
using ecommerceAPI.Persistance.Contexts;
using ecommerceAPI.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ecommerceAPI.Persistance
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EcommerceAPIDbContext>(options =>
                options.UseSqlServer(StaticConfigurations.ConnectionString));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
