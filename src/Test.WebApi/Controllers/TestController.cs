using Microsoft.AspNetCore.Mvc;

namespace Test.WebApi.Controllers;

public sealed class TestController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok();
    }
}
