namespace BasicApi.UnitTests.Controllers;

using BasicApi.Controllers;
using BasicApi.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

[TestClass]
public class AgeControllerTests
{
    private AgeController _sut;

    private Mock<IAgeService> _ageServiceMock;
    private Mock<ILogger<AgeController>> _loggerMock;

    [TestInitialize]
    public void TestInitialize()
    {
        _ageServiceMock = new Mock<IAgeService>();
        _loggerMock = new Mock<ILogger<AgeController>>();

        _sut = new AgeController(_ageServiceMock.Object, _loggerMock.Object);
    }

    [TestMethod]
    public async Task Get_ReturnsOkayObjectResult()
    {
        // Arrange
        const int age = 21;

        // Act
        var result = await _sut.Get(age) as OkObjectResult;

        // Assert
        result.Should().NotBeNull();
        result!.StatusCode.Should().Be(StatusCodes.Status200OK);
    }
}