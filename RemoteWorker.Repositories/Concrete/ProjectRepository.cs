using Microsoft.EntityFrameworkCore;
using RemoteWorker.Data;
using RemoteWorker.DTOs;
using RemoteWorker.Models;
using Microsoft.Extensions.Logging;
using RemoteWorker.Repositories.Abstract;


namespace RemoteWorker.Repositories.Concrete
{
    public class ProjectRepository(RemoteWorkerDbContext context, ILogger<ProjectRepository> logger) : GenericRemoteWorkerRepository<ProjectModel>(context, logger), IProjectRepository
    {
        private readonly RemoteWorkerDbContext _context = context;

        public async Task<IEnumerable<ProjectWithOwnerDto>> GetProjectWithOwnersAsync(Guid projectId)
        {
            var projectWithOwners = await _context.Project
                .Join(
                    _context.User,
                    project => project.OwnerId,
                    user => user.UserId,
                    (project, user) => new ProjectWithOwnerDto
                    {
                        Id = project.ProjectId,
                        Name = project.Name,
                        Description = project.Description,
                        OwnerId = user.UserId,
                        OwnerName = user.FullName,
                        OwnerDescription = user.Role ?? string.Empty,
                        OwnerOwnerId = user.UserId // Assuming this maps to OwnerOwnerId
                    }
                )
                .Where(dto => dto.Id == projectId)
                .ToListAsync();

            return projectWithOwners;
        }
    }
}
