// add a namespace for WeatherForecastController
using WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetRange method of WeatherForecastController
    // Path: test/WebApiTests/WeatherForecastControllerTests.cs
    [TestMethod]
    public void GetRange_Returns_WeatherForecast()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.GetRange(new DateRange { Length = 3 });

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(3, result.Count());
    }
}