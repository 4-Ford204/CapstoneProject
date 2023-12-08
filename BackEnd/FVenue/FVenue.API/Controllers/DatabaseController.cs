using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        [HttpGet, Route("InitDatabase")]
        public IActionResult InitDatabase()
        {
            return Ok("Database initialized");
        }
    }
}
