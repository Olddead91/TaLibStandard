// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Candles.CandleEngulfing;

public class CandleEngulfing<T> : CandleIndicator<T>
    where T : IFloatingPoint<T>
{
    public CandleEngulfing(in T[] open, in T[] high, in T[] low, in T[] close)
        : base(open, high, low, close)
    {
    }

    public CandleEngulfingResult Compute(int startIdx, int endIdx)
    {
        // Initialize output variables 
        int outBegIdx = default;
        int outNBElement = default;
        int[] outInteger = new int[endIdx - startIdx + 1];
            
        // Validate the requested output range.
        if (startIdx < 0)
        {
            return new CandleEngulfingResult(OutOfRangeStartIndex, outBegIdx, outNBElement, outInteger);
        }

        if (endIdx < 0 || endIdx < startIdx)
        {
            return new CandleEngulfingResult(OutOfRangeEndIndex, outBegIdx, outNBElement, outInteger);
        }

        // Verify required price component.
        // ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (Open == null || High == null || Low == null || Close == null)
        // ReSharper restore ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        {
            return new CandleEngulfingResult(BadParam, outBegIdx, outNBElement, outInteger);
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
            return new CandleEngulfingResult(Success, outBegIdx, outNBElement, outInteger);
        }

        // Do the calculation using tight loops.
        // Add-up the initial period, except for the last value.
        int i = startIdx;

        /* Proceed with the calculation for the requested range.
         * Must have:
         * - first: black (white) real body
         * - second: white (black) real body that engulfs the prior real body
         * outInteger is positive (1 to 100) when bullish or negative (-1 to -100) when bearish;
         * the user should consider that an engulfing must appear in a downtrend if bullish or in an uptrend if bearish,
         * while this function does not consider it
         */
        int outIdx = 0;
        do
        {
            bool isEngulfing = GetPatternRecognition(i);

            outInteger[outIdx++] = isEngulfing ? GetCandleColor(i) * 100 : 0;

            i++;
        } while (i <= endIdx);

        // All done. Indicate the output limits and return.
        outNBElement = outIdx;
        outBegIdx = startIdx;
            
        return new CandleEngulfingResult(Success, outBegIdx, outNBElement, outInteger);
    }

    /// <inheritdoc />
    public override bool GetPatternRecognition(int i)
    {
        bool isEngulfing =
            (
                // white engulfs black
                GetCandleColor(i) == 1 &&
                GetCandleColor(i - 1) == -1 &&
                Close[i] > Open[i - 1] &&
                Open[i] < Close[i - 1]
            )
            ||
            (
                // black engulfs white
                GetCandleColor(i) == -1 &&
                GetCandleColor(i - 1) == 1 &&
                Open[i] > Close[i - 1] &&
                Close[i] < Open[i - 1]
            );
            
        return isEngulfing;
    }

    /// <inheritdoc />
    public override int GetLookback()
    {
        return 2;
    }
}
