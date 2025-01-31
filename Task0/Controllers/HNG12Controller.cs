using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System;

namespace HNG12API.Controllers
{
    [ApiController]
    [Route("api/hng12")]
    public class HNG12Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDetails()
        {
            var response = new
            {
                email = "mubaraktoye@gmail.com", 
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/Mubaraktoye/HNGTaskZero"
            };
            return Ok(response);
        }
    }
}
