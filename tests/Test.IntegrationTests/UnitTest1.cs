using Moq;
using Test.Services;
using Test.WebApi.Controllers;

namespace Test.IntegrationTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var logic = new Mock<IService>(MockBehavior.Strict);

        logic
        .Setup(i => i.Add());

        new WeatherForecastController(logic.Object).Add();
    }
}
