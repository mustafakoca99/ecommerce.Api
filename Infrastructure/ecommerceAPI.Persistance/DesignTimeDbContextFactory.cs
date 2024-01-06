using ecommerceAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ecommerceAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EcommerceAPIDbContext>
    {
        public EcommerceAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EcommerceAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(
                "server=(localdb)\\kmssqllocaldb;database=ecommerce;user=sa;password=M.k12345"
                );
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
