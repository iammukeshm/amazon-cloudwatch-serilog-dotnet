using Microsoft.AspNetCore.Mvc;

namespace AWSCloudwatch.Serilog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }
        [HttpGet("{id:int}")]
        public IActionResult GetAsync(int id)
        {
            _logger.LogDebug("Received Request with id as {id}", id);
            _logger.LogInformation("Processing your request");
            _logger.LogError("Some Errors occcured.");
            return Ok("Logged");
        }
    }
}
