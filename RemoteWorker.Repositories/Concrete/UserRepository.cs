using RemoteWorker.Repositories.Abstract;
using RemoteWorker.Data;
using RemoteWorker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace RemoteWorker.Repositories.Concrete
{
    public class UserRepository(RemoteWorkerDbContext context, ILogger<UserRepository> logger) : IUserRepository
    {
        private readonly RemoteWorkerDbContext _context = context;
        private readonly ILogger<UserRepository> _logger = logger;

        public async Task<UserModel> GetUserByIdAsync(Guid id)
        {
            var user = await _context.User.FindAsync(id);
            return user ?? throw new InvalidOperationException($"User with ID {id} not found.");
        }

        public async Task<UserModel> GetUserByEmailAsync(string email)
        {
            var user = await _context.User.FirstOrDefaultAsync(u => u.Email == email);
            return user ?? throw new InvalidOperationException($"User with email {email} not found.");
        }

        public async Task<Guid> AddUser(UserModel user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            user.CreatedAt = DateTime.UtcNow;
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user.UserId;
        }
    }
}
