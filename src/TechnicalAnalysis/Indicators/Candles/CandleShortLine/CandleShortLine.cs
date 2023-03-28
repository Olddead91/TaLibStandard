using System.Numerics;
using TechnicalAnalysis.Common;
using static TechnicalAnalysis.Common.CandleSettingType;
using static TechnicalAnalysis.Common.RetCode;

namespace TechnicalAnalysis.Candles.CandleShortLine;

public class CandleShortLine<T> : CandleIndicator<T>
    where T : IFloatingPoint<T>
{
    private T _bodyPeriodTotal;
    private T _shadowPeriodTotal;

    public CandleShortLine(in T[] open, in T[] high, in T[] low, in T[] close)
        : base(open, high, low, close)
    {
    }

    public CandleShortLineResult Compute(int startIdx, int endIdx)
    {
        // Initialize output variables 
        int outBegIdx = default;
        int outNBElement = default;
        int[] outInteger = new int[endIdx - startIdx + 1];
            
        // Validate the requested output range.
        if (startIdx < 0)
        {
            return new CandleShortLineResult(OutOfRangeStartIndex, outBegIdx, outNBElement, outInteger);
        }

        if (endIdx < 0 || endIdx < startIdx)
        {
            return new CandleShortLineResult(OutOfRangeEndIndex, outBegIdx, outNBElement, outInteger);
        }

        // Verify required price component.
        // ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (Open == null || High == null || Low == null || Close == null)
        // ReSharper restore ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        {
            return new CandleShortLineResult(BadParam, outBegIdx, outNBElement, outInteger);
        }

        // Identify the minimum number of price bar needed to calculate at least one output.
        int lookbackTotal = GetLookback();

        // Move up the start index if there is not enough initial data.
        if (startIdx < lookbackTotal)
        {
            startIdx = lookbackTotal;
        }

        // Make sure there is still something to evaluate.
        if (startIdx > endIdx)
        {
            return new CandleShortLineResult(Success, outBegIdx, outNBElement, outInteger);
        }

        // Do the calculation using tight loops.
        // Add-up the initial period, except for the last value.
        int bodyTrailingIdx = startIdx - GetCandleAvgPeriod(BodyShort);
        int shadowTrailingIdx = startIdx - GetCandleAvgPeriod(ShadowShort);
            
        int i = bodyTrailingIdx;
        while (i < startIdx)
        {
            _bodyPeriodTotal += GetCandleRange(BodyShort, i);
            i++;
        }

        i = shadowTrailingIdx;
        while (i < startIdx)
        {
            _shadowPeriodTotal += GetCandleRange(ShadowShort, i);
            i++;
        }

        /* Proceed with the calculation for the requested range.
         * Must have:
         * - short real body
         * - short upper and lower shadow
         * The meaning of "short" is specified with TA_SetCandleSettings
         * outInteger is positive (1 to 100) when white, negative (-1 to -100) when black;
         * it does not mean bullish or bearish
         */
        int outIdx = 0;
        do
        {
            outInteger[outIdx++] = GetPatternRecognition(i) ? GetCandleColor(i) * 100 : 0;

            /* add the current range and subtract the first range: this is done after the pattern recognition 
             * when avgPeriod is not 0, that means "compare with the previous candles" (it excludes the current candle)
             */
            _bodyPeriodTotal +=
                GetCandleRange(BodyShort, i) -
                GetCandleRange(BodyShort, bodyTrailingIdx);

            _shadowPeriodTotal +=
                GetCandleRange(ShadowShort, i) -
                GetCandleRange(ShadowShort, shadowTrailingIdx);

            i++;
            bodyTrailingIdx++;
            shadowTrailingIdx++;
        } while (i <= endIdx);

        // All done. Indicate the output limits and return.
        outNBElement = outIdx;
        outBegIdx = startIdx;
            
        return new CandleShortLineResult(Success, outBegIdx, outNBElement, outInteger);
    }

    /// <inheritdoc />
    public override bool GetPatternRecognition(int i)
    {
        bool isShortLine =
            GetRealBody(i) < GetCandleAverage(BodyShort, _bodyPeriodTotal, i) &&
            GetUpperShadow(i) < GetCandleAverage(ShadowShort, _shadowPeriodTotal, i) &&
            GetLowerShadow(i) < GetCandleAverage(ShadowShort, _shadowPeriodTotal, i);
            
        return isShortLine;
    }

    /// <inheritdoc />
    public override int GetLookback()
    {
        return GetCandleMaxAvgPeriod(BodyShort, ShadowShort);
    }
}
