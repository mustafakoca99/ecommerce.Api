using ecommerceAPI.Application.Repositories;
using ecommerceAPI.Domain.Entites;
using ecommerceAPI.Persistance.Contexts;

namespace ecommerceAPI.Persistance.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}
