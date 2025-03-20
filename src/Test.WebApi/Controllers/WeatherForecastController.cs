using Microsoft.AspNetCore.Mvc;
using Test.Services;

namespace Test.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IService service) : ControllerBase
{
    [HttpPost]
    public void Add()
    {
        if(true)
        {
        }

        service.Add();
    }

    [HttpGet]
    public List<Guid> Get()
    {
        return service.GetAll();
    }
}
