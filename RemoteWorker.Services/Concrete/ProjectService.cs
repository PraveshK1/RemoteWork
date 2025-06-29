using Microsoft.Extensions.Logging;
using RemoteWorker.DTOs;
using RemoteWorker.Repositories.Abstract;
using RemoteWorker.Services.Abstract;
//TODO Add the DataAnnotations namespace and use Validator i.e.  Validator.ValidateObject(dto, new ValidationContext(dto), validateAllProperties: true);


namespace RemoteWorker.Services.Concrete
{
    public class ProjectService(IProjectRepository repository, ILogger<ProjectService> logger) : IProjectService
    {
        private readonly IProjectRepository _repository = repository;
        private readonly ILogger<ProjectService> _logger = logger;

        public async Task<ProjectDto> GetProjectById(Guid Id)
        {
            var project = await _repository.GetByIdAsync(Id);
            return new ProjectDto
            {
                Name = project.Name,
                Description = project.Description,
                Status = project.Status,
            };
        }

        public async Task<IEnumerable<ProjectWithOwnerDto>> GetProjectWithOwnersAsync(Guid projectId)
        {
            var projectsWithOwners = await _repository.GetProjectWithOwnersAsync(projectId);
            return projectsWithOwners;
        }
    }
}
