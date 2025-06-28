
using System.Linq.Expressions;

namespace RemoteWorker.Repositories.Abstract
{
    public interface IRemoteWorkerRepository<T> where T : class
    {
        Task<T> GetByIdAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object id);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<bool> SaveChangesAsync();
    }
}
