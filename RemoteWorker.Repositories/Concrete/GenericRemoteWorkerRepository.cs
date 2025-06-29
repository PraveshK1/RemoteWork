using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using RemoteWorker.Data;
using RemoteWorker.Repositories.Abstract;
using System.Linq.Expressions;

namespace RemoteWorker.Repositories.Concrete
{
    public class GenericRemoteWorkerRepository<T>(RemoteWorkerDbContext context, ILogger<GenericRemoteWorkerRepository<T>> logger) : IGenericRemoteWorkerRepository<T> where T : class
    {
        private readonly RemoteWorkerDbContext _context = context;
        private readonly DbSet<T> _dbSet = context.Set<T>();
        private readonly ILogger<GenericRemoteWorkerRepository<T>> _logger = logger;

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public async Task DeleteAsync(object id) => await _dbSet
            .Where(e => EF.Property<T>(e, "Id") == id)
            .ExecuteDeleteAsync();

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<T> GetByIdAsync(object id) => await _dbSet.FindAsync(id)
            ?? throw new KeyNotFoundException($"Entity with id {id} not found.");

        public async Task<bool> SaveChangesAsync() => await _context.SaveChangesAsync() > 0;

        public Task UpdateAsync(T entity) => _dbSet.Update(entity) switch
        {
            EntityEntry<T> => Task.CompletedTask,
            _ => throw new InvalidOperationException("Update operation failed.")
        };
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }


    }
}
