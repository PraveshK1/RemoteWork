using RemoteWorker.DTOs;

namespace RemoteWorker.Services.Abstract
{
    public interface IProjectService
    {
        Task<ProjectDto> GetProjectById(Guid Id);
        Task<IEnumerable<ProjectWithOwnerDto>> GetProjectWithOwnersAsync(Guid projectId);
    }
}
