using Microsoft.AspNetCore.Mvc;
using Test.DataAccess;

namespace Test.WebApi.Controllers;

[ApiController]
[Route("health")]
public sealed class HealthController(ConcreteDbContext dbContext)
    : ControllerBase
{
    [HttpGet]
    public async Task<object> Get()
    {
        return await dbContext.Database.CanConnectAsync().ConfigureAwait(false);
    }
}
