using ecommerceAPI.Domain.Entites.Common;

namespace ecommerceAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entity);
        bool Remove(T entity);
        Task<bool> Remove(string id);
        bool RemoveRange(List<T> entities);
        bool Update(T entity);
        Task<int> SaveAsync();
    }
}
