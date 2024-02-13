namespace BasicApi.UnitTests.Services;

using BasicApi.Services;
using FluentAssertions;

[TestClass]
public class AgeServiceTests
{
    private IAgeService _sut;


    [TestInitialize]
    public void TestInitialize()
    {
        _sut = new AgeService();
    }

    [TestMethod]
    [DataRow(21, true)]
    public void IsAdult_ReceivesNumber_ReturnsBoolean(int age, bool expected)
    {
        // Arrange

        // Act
        var result = _sut.IsAdult(age);

        // Assert
        result.Should().Be(true);
    }
}