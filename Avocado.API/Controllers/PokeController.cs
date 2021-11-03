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
            return Ok(BaseMessage());
        }

        public string BaseMessage()
        {
            return "This is a poke";
        }
    }
}