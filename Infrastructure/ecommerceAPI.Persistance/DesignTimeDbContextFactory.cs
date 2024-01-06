using ecommerceAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ecommerceAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EcommerceAPIDbContext>
    {
        public EcommerceAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EcommerceAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(StaticConfigurations.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
