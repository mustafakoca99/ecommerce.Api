using ecommerceAPI.Application.Repositories;
using ecommerceAPI.Domain.Entites;
using ecommerceAPI.Persistance.Contexts;

namespace ecommerceAPI.Persistance.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}
