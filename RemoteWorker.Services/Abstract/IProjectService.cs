using RemoteWorker.DTOs;

namespace RemoteWorker.Services.Abstract
{
    public interface IProjectService
    {
        Task<ProjectDto> GetProjectById(Guid Id);
    }
}
