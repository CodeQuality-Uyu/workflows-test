using Microsoft.AspNetCore.Mvc;

public sealed class TestController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok();
    }
}
