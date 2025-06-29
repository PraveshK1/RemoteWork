using Microsoft.AspNetCore.Mvc;
using RemoteWorker.Services.Abstract;

namespace RemoteWorker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IUserService service, ILogger<UserController> logger) : Controller
    {
        private IUserService _service = service;
        private ILogger<UserController> _logger = logger;

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _service.GetUserByIdAsync(id);
            return user != null ? Ok(user) : NotFound();
        }


    }
}
