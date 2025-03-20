using Test.Services;

namespace Test.UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        new Service().Add();
    }
}
