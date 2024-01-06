using ecommerceAPI.Application.Repositories;
using ecommerceAPI.Domain.Entites;
using ecommerceAPI.Persistance.Contexts;

namespace ecommerceAPI.Persistance.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}
