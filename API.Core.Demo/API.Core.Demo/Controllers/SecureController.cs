using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Core.Demo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [HttpGet("secret")]
    [Authorize]
    public IActionResult Secret()
    {
        return Ok(new { message = "Authorized" });
    }
}