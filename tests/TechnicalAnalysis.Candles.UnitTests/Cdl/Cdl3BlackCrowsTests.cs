// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Candles.UnitTests.Cdl;

public class Cdl3BlackCrowsTests : CdlTestsBase
{
    protected override Func<int, int, float[], float[], float[], float[], CandleIndicatorResult> SUT { get; }
        = TACandle.Cdl3BlackCrows;

    // [Fact]
    // public void GetPatternRecognitionPatternDetected()
    // {
    //     // Arrange
    //     float[] open = [100f, 135f, 130f];
    //     float[] close = [120f, 125f, 110f];
    //     Candle3BlackCrows<float> crows = new(open, null!, null!, close);
    //     
    //     // Act
    //     bool isPatternDetected = crows.GetPatternRecognition(2);
    //
    //     // Assert
    //     isPatternDetected.ShouldBeTrue();
    // }
    
    [Theory]
    [InlineData(typeof(float))]
    [InlineData(typeof(double))]
    [InlineData(typeof(decimal))]
    [InlineData(typeof(Half))]
    public void Cdl3BlackCrowsFloatingPoint(Type floatingPointType)
    {
        InvokeGeneric(nameof(Cdl3BlackCrows), floatingPointType);
    }
    
    private static void Cdl3BlackCrows<T>()
        where T : IFloatingPoint<T>
    {
        // Arrange
        Fixture fixture = new();
        const int StartIdx = 0;
        const int EndIdx = 99;
        T[] open = [.. fixture.CreateMany<T>(100)];
        T[] high = [.. fixture.CreateMany<T>(100)];
        T[] low = [.. fixture.CreateMany<T>(100)];
        T[] close = [.. fixture.CreateMany<T>(100)];
            
        // Act
        CandleIndicatorResult result = TACandle.Cdl3BlackCrows(
            StartIdx, EndIdx, open, high, low, close);
        
        // Assert
        result.ShouldNotBeNull();
        result.RetCode.ShouldBe(RetCode.Success);
    }
}
