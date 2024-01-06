using ecommerceAPI.Application.Repositories;
using ecommerceAPI.Domain.Entites;
using ecommerceAPI.Persistance.Contexts;

namespace ecommerceAPI.Persistance.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}
