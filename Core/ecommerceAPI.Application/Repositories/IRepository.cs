using ecommerceAPI.Domain.Entites.Common;
using Microsoft.EntityFrameworkCore;

namespace ecommerceAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
