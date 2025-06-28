using Microsoft.Extensions.Logging;
using RemoteWorker.DTOs;
using RemoteWorker.Models;
using RemoteWorker.Repositories.Abstract;
using RemoteWorker.Services.Abstract;
//TODO Add the DataAnnotations namespace and use Validator i.e.  Validator.ValidateObject(dto, new ValidationContext(dto), validateAllProperties: true);


namespace RemoteWorker.Services.Concrete
{ 
    public class ProjectService(IRemoteWorkerRepository<ProjectModel> repository, ILogger<ProjectService> logger) : IProjectService
    {
        private readonly IRemoteWorkerRepository<ProjectModel> _repository = repository;
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
    }
}
