using ecommerceAPI.Application.Repositories;
using ecommerceAPI.Domain.Entites;
using ecommerceAPI.Persistance.Contexts;

namespace ecommerceAPI.Persistance.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}
