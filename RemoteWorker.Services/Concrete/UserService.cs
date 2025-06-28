using RemoteWorker.Services.Abstract;
using RemoteWorker.DTOs;
using RemoteWorker.Repositories.Abstract;
using Microsoft.Extensions.Logging;
using RemoteWorker.Models;

namespace RemoteWorker.Services.Concrete
{
    public class UserService(IRemoteWorkerRepository<UserModel> repository, ILogger<UserService> logger) : IUserService
    {
        private readonly IRemoteWorkerRepository<UserModel> _repository = repository;
        private readonly ILogger<UserService> _logger = logger;

        public async Task<UserDto?> GetUserByIdAsync(Guid id)
        {
            var user = await _repository.GetByIdAsync(id);
            if (user == null) { return null; }

            return new UserDto
            {
                UserId = user.UserId,
                FullName = user.FullName,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                Role = user.Role ?? string.Empty,
                Status = user.Status ?? string.Empty,
                CreatedAt = user.CreatedAt,
                LastLogin = user.LastLogin
            };
        }

       

    }
}
