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

        [HttpGet]
        public async Task<IActionResult> GetProjectById(Guid Id)
        {
            _logger.LogInformation("Fetching project with ID: {Id}", Id);
            var project = await _service.GetProjectById(Id);
            return project != null ? Ok(project) : NotFound();
  
        }

    }
}
