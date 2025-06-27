using RemoteWorker.Data;
using RemoteWorker.Models;

namespace RemoteWorker.Repositories.Abstract
{
    public interface IUserRepository
    {
        Task<UserModel> GetByIdAsync(string id);
    }
}
