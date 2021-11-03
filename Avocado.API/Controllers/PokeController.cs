using Microsoft.AspNetCore.Mvc;

namespace Avocado.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokeController : ControllerBase
    {
        public PokeController()
        {
            
        }
        
        [HttpGet]
        public IActionResult Random()
        {
            return Ok("This is a random EVIL avocado poke ;(");
        }
    }
}