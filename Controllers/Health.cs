using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Health : ControllerBase
    {
        [HttpGet("health")]
        public IActionResult HealthCheck()
        {
            return Ok("API is healthy");
        }
    }
}