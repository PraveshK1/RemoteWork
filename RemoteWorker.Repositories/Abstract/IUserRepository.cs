using RemoteWorker.Models;

namespace RemoteWorker.Repositories.Abstract
{
    public interface IUserRepository
    {
        Task<UserModel> GetUserByIdAsync(Guid id);
        Task<UserModel> GetUserByEmailAsync(string email);
        Task<Guid> AddUser(UserModel user);

    }
}
