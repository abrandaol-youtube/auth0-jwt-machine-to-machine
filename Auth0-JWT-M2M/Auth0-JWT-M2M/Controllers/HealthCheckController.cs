using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth0_JWT_M2M.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        [Authorize("write:credor_scope")]
        public IActionResult GetInfo()
        {
            var authentication = HttpContext.User.Claims;

            return Ok($"{DateTime.UtcNow:o}");
        }
    }
}

