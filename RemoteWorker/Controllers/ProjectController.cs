using Microsoft.AspNetCore.Mvc;
using RemoteWorker.Services.Abstract;

namespace RemoteWorker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController(IProjectService service, ILogger<ProjectController> logger) : ControllerBase
    {
        private readonly IProjectService _service = service;
        private readonly ILogger<ProjectController> _logger = logger;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectById(Guid id)
        {
            _logger.LogInformation("Fetching project with ID: {id}", id);
            var project = await _service.GetProjectById(id);
            return project != null ? Ok(project) : NotFound();
        }

        [HttpGet("WithOwners/{projectId}")]
        public async Task<IActionResult> GetProjectWithOwnersAsync(Guid projectId)
        {
            _logger.LogInformation("Fetching project with owners for project ID: {ProjectId}", projectId);
            var projectsWithOwners = await _service.GetProjectWithOwnersAsync(projectId);
            return Ok(projectsWithOwners);
        }
    }
}
