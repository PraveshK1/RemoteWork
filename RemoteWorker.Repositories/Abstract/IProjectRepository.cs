using RemoteWorker.DTOs;
using RemoteWorker.Models;
namespace RemoteWorker.Repositories.Abstract
{
    public interface IProjectRepository : IGenericRemoteWorkerRepository<ProjectModel>
    {
        Task<IEnumerable<ProjectWithOwnerDto>> GetProjectWithOwnersAsync(Guid projectId);
    }
}
