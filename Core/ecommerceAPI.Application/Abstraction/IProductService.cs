using ecommerceAPI.Domain.Entites;

namespace ecommerceAPI.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
