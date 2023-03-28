namespace TechnicalAnalysis.Tests.Indicators.Func;

public class SubTests
{
    [Fact]
    public void SubDouble()
    {
        // Arrange
        Fixture fixture = new();
        const int startIdx = 0;
        const int endIdx = 99;
        double[] real0 = fixture.CreateMany<double>(100).ToArray();
        double[] real1 = fixture.CreateMany<double>(100).ToArray();
            
        // Act
        var actualResult = TAMath.Sub(
            startIdx,
            endIdx,
            real0,
            real1);

        // Assert
        actualResult.Should().NotBeNull();
        actualResult.RetCode.Should().Be(RetCode.Success);
    }
        
    [Fact]
    public void SubFloat()
    {
        // Arrange
        Fixture fixture = new();
        const int startIdx = 0;
        const int endIdx = 99;
        float[] real0 = fixture.CreateMany<float>(100).ToArray();
        float[] real1 = fixture.CreateMany<float>(100).ToArray();
            
        // Act
        var actualResult = TAMath.Sub(
            startIdx,
            endIdx,
            real0,
            real1);

        // Assert
        actualResult.Should().NotBeNull();
        actualResult.RetCode.Should().Be(RetCode.Success);
    }
}