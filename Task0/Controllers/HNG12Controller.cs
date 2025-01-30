using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System;

namespace HNG12API.Controllers
{
    [ApiController]
    [Route("api/hng12")]
    //[EnableCors("AllowAll")] // Enable CORS
    public class HNG12Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDetails()
        {
            var response = new
            {
                email = "your-email@example.com", // Replace with your HNG12 email
                current_datetime = DateTime.UtcNow.ToString("o"), // ISO 8601 format
                github_url = "https://github.com/yourusername/your-repo" // Replace with your GitHub repo URL
            };
            return Ok(response);
        }
    }
}
