using RemoteWorker.DTOs;

namespace RemoteWorker.Services.Abstract
{
    public interface IUserService
    {
        Task<UserDto?> GetUserByIdAsync(Guid id);
    }
}
