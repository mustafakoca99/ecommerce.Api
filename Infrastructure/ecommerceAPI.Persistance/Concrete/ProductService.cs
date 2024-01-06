using ecommerceAPI.Application.Abstraction;
using ecommerceAPI.Domain.Entites;

namespace ecommerceAPI.Persistance.Concrete
{
    internal class ProductService : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new() { Id = Guid.NewGuid(), Name = "test product", Price = 1100, Stock = 10 },
        };
    }
}
