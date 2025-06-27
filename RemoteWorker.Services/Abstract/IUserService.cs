using RemoteWorker.DTOs;

namespace RemoteWorker.Services.Abstract
{
    public interface IUserService
    {
        Task<UserDTO?> GetUserByIdAsync(string id);
    }
}
