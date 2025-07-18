// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAFunc
{
    /// <summary>
    /// Calculates the Hilbert Transform - Trend vs Cycle Mode.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation within the input array.</param>
    /// <param name="endIdx">The ending index for the calculation within the input array.</param>
    /// <param name="inReal">Input array of price data (typically closing prices).</param>
    /// <param name="outBegIdx">The index of the first valid output value.</param>
    /// <param name="outNBElement">The number of valid output elements.</param>
    /// <param name="outInteger">Output array for the trend mode values (0 = cycle mode, 1 = trend mode).</param>
    /// <returns>A RetCode indicating the success or failure of the calculation.</returns>
    /// <remarks>
    /// The Hilbert Transform - Trend vs Cycle Mode is a market state indicator developed by John Ehlers
    /// that determines whether the market is in a trending or cycling mode. This distinction is crucial
    /// for selecting appropriate trading strategies and indicators.
    /// 
    /// How it works:
    /// 1. Uses the Hilbert Transform to decompose price into in-phase and quadrature components
    /// 2. Calculates the dominant cycle period and phase
    /// 3. Computes a trendline using weighted average of recent prices
    /// 4. Applies multiple criteria to determine market mode:
    ///    - Phase relationship between sine and lead sine
    ///    - Duration in current trend relative to cycle period
    ///    - Rate of phase change
    ///    - Price deviation from trendline
    /// 
    /// Output interpretation:
    /// - 0 = Cycle Mode: Market is moving sideways in a cyclical pattern
    /// - 1 = Trend Mode: Market is in a directional trend
    /// 
    /// Market mode characteristics:
    /// - Cycle Mode: Use oscillators, support/resistance, mean reversion strategies
    /// - Trend Mode: Use trend-following indicators, breakout strategies, momentum trading
    /// 
    /// Decision criteria for trend mode:
    /// - Price deviates more than 1.5% from the trendline
    /// - Current trend has persisted for at least half the dominant cycle period
    /// - Phase is advancing at a normal rate (not too fast or too slow)
    /// - Sine/lead sine crossover patterns indicate trend continuation
    /// 
    /// Common applications:
    /// - Adaptive trading systems that switch strategies based on market state
    /// - Filter for trend-following vs mean-reversion signals
    /// - Risk management (different position sizing for trends vs cycles)
    /// - Indicator parameter adaptation based on market conditions
    /// 
    /// Limitations:
    /// - Requires significant historical data (minimum 63 bars plus unstable period)
    /// - Subject to lag in detecting mode transitions
    /// - May produce frequent mode switches in choppy markets
    /// - Most effective when combined with other confirmation indicators
    /// </remarks>
    public static RetCode HtTrendMode(
        int startIdx,
        int endIdx,
        in double[] inReal,
        ref int outBegIdx,
        ref int outNBElement,
        ref int[] outInteger)
    {
        double smoothedValue;
        const double A = 0.0962;
        const double B = 0.5769;
        double[] detrender_Odd = new double[3];
        double[] detrender_Even = new double[3];
        double[] Q1_Odd = new double[3];
        double[] Q1_Even = new double[3];
        double[] jI_Odd = new double[3];
        double[] jI_Even = new double[3];
        double[] jQ_Odd = new double[3];
        double[] jQ_Even = new double[3];
        int smoothPrice_Idx = 0;
        int maxIdx_smoothPrice = 49;
        if (startIdx < 0)
        {
            return OutOfRangeStartIndex;
        }

        if (endIdx < 0 || endIdx < startIdx)
        {
            return OutOfRangeEndIndex;
        }

        if (inReal == null!)
        {
            return BadParam;
        }

        if (outInteger == null)
        {
            return BadParam;
        }

        double[] smoothPrice = new double[maxIdx_smoothPrice + 1];

        double iTrend3 = 0.0;
        double iTrend2 = iTrend3;
        double iTrend1 = iTrend2;
        int daysInTrend = 0;
        double DCPhase = 0.0;
        double prevDCPhase = DCPhase;
        double sine = 0.0;
        double prevSine = sine;
        double leadSine = 0.0;
        double prevLeadSine = leadSine;
        double tempReal = Math.Atan(1.0);
        double rad2Deg = 45.0 / tempReal;
        double deg2Rad = 1.0 / rad2Deg;
        double constDeg2RadBy360 = tempReal * 8.0;
        int lookbackTotal = (int)TACore.Globals.UnstablePeriod[FuncUnstId.HtTrendMode] + 63;
        if (startIdx < lookbackTotal)
        {
            startIdx = lookbackTotal;
        }

        if (startIdx > endIdx)
        {
            outBegIdx = 0;
            outNBElement = 0;
            return Success;
        }

        outBegIdx = startIdx;
        int trailingWMAIdx = startIdx - lookbackTotal;
        int today = trailingWMAIdx;
        tempReal = inReal[today];
        today++;
        double periodWMASub = tempReal;
        double periodWMASum = tempReal;
        tempReal = inReal[today];
        today++;
        periodWMASub += tempReal;
        periodWMASum += tempReal * 2.0;
        tempReal = inReal[today];
        today++;
        periodWMASub += tempReal;
        periodWMASum += tempReal * 3.0;
        double trailingWMAValue = 0.0;
        int i = 34;
        do
        {
            tempReal = inReal[today];
            today++;
            periodWMASub += tempReal;
            periodWMASub -= trailingWMAValue;
            periodWMASum += tempReal * 4.0;
            trailingWMAValue = inReal[trailingWMAIdx];
            trailingWMAIdx++;
            smoothedValue = periodWMASum * 0.1;
            periodWMASum -= periodWMASub;
            i--;
        }
        while (i != 0);

        int hilbertIdx = 0;
        detrender_Odd[0] = 0.0;
        detrender_Odd[1] = 0.0;
        detrender_Odd[2] = 0.0;
        detrender_Even[0] = 0.0;
        detrender_Even[1] = 0.0;
        detrender_Even[2] = 0.0;
        double detrender = 0.0;
        double prev_detrender_Odd = 0.0;
        double prev_detrender_Even = 0.0;
        double prev_detrender_input_Odd = 0.0;
        double prev_detrender_input_Even = 0.0;
        Q1_Odd[0] = 0.0;
        Q1_Odd[1] = 0.0;
        Q1_Odd[2] = 0.0;
        Q1_Even[0] = 0.0;
        Q1_Even[1] = 0.0;
        Q1_Even[2] = 0.0;
        double prevQ1Odd = 0.0;
        double prev_Q1_Even = 0.0;
        double prev_Q1_input_Odd = 0.0;
        double prev_Q1_input_Even = 0.0;
        jI_Odd[0] = 0.0;
        jI_Odd[1] = 0.0;
        jI_Odd[2] = 0.0;
        jI_Even[0] = 0.0;
        jI_Even[1] = 0.0;
        jI_Even[2] = 0.0;
        double jI = 0.0;
        double prev_jI_Odd = 0.0;
        double prev_jI_Even = 0.0;
        double prev_jI_input_Odd = 0.0;
        double prev_jI_input_Even = 0.0;
        jQ_Odd[0] = 0.0;
        jQ_Odd[1] = 0.0;
        jQ_Odd[2] = 0.0;
        jQ_Even[0] = 0.0;
        jQ_Even[1] = 0.0;
        jQ_Even[2] = 0.0;
        double jQ = 0.0;
        double prev_jQ_Odd = 0.0;
        double prev_jQ_Even = 0.0;
        double prev_jQ_input_Odd = 0.0;
        double prev_jQ_input_Even = 0.0;
        double period = 0.0;
        int outIdx = 0;
        double prevQ2 = 0.0;
        double prevI2 = prevQ2;
        double Im = 0.0;
        double Re = Im;
        double I1ForEvenPrev3 = 0.0;
        double I1ForOddPrev3 = I1ForEvenPrev3;
        double I1ForEvenPrev2 = 0.0;
        double I1ForOddPrev2 = I1ForEvenPrev2;
        double smoothPeriod = 0.0;
        i = 0;
        while (i < 50)
        {
            smoothPrice[i] = 0.0;
            i++;
        }

        DCPhase = 0.0;
        while (true)
        {
            double hilbertTempReal;
            double I2;
            double Q2;
            if (today > endIdx)
            {
                outNBElement = outIdx;
                return Success;
            }

            double adjustedPrevPeriod = (0.075 * period) + 0.54;
            double todayValue = inReal[today];
            periodWMASub += todayValue;
            periodWMASub -= trailingWMAValue;
            periodWMASum += todayValue * 4.0;
            trailingWMAValue = inReal[trailingWMAIdx];
            trailingWMAIdx++;
            smoothedValue = periodWMASum * 0.1;
            periodWMASum -= periodWMASub;
            smoothPrice[smoothPrice_Idx] = smoothedValue;
            double Q1 = 0.0;
            if (today % 2 == 0)
            {
                hilbertTempReal = A * smoothedValue;
                detrender = -detrender_Even[hilbertIdx];
                detrender_Even[hilbertIdx] = hilbertTempReal;
                detrender += hilbertTempReal;
                detrender -= prev_detrender_Even;
                prev_detrender_Even = B * prev_detrender_input_Even;
                detrender += prev_detrender_Even;
                prev_detrender_input_Even = smoothedValue;
                detrender *= adjustedPrevPeriod;
                hilbertTempReal = A * detrender;
                Q1 = -Q1_Even[hilbertIdx];
                Q1_Even[hilbertIdx] = hilbertTempReal;
                Q1 += hilbertTempReal;
                Q1 -= prev_Q1_Even;
                prev_Q1_Even = B * prev_Q1_input_Even;
                Q1 += prev_Q1_Even;
                prev_Q1_input_Even = detrender;
                Q1 *= adjustedPrevPeriod;
                hilbertTempReal = A * I1ForEvenPrev3;
                jI = -jI_Even[hilbertIdx];
                jI_Even[hilbertIdx] = hilbertTempReal;
                jI += hilbertTempReal;
                jI -= prev_jI_Even;
                prev_jI_Even = B * prev_jI_input_Even;
                jI += prev_jI_Even;
                prev_jI_input_Even = I1ForEvenPrev3;
                jI *= adjustedPrevPeriod;
                hilbertTempReal = A * Q1;
                jQ = -jQ_Even[hilbertIdx];
                jQ_Even[hilbertIdx] = hilbertTempReal;
                jQ += hilbertTempReal;
                jQ -= prev_jQ_Even;
                prev_jQ_Even = B * prev_jQ_input_Even;
                jQ += prev_jQ_Even;
                prev_jQ_input_Even = Q1;
                jQ *= adjustedPrevPeriod;
                hilbertIdx++;
                if (hilbertIdx == 3)
                {
                    hilbertIdx = 0;
                }

                Q2 = (0.2 * (Q1 + jI)) + (0.8 * prevQ2);
                I2 = (0.2 * (I1ForEvenPrev3 - jQ)) + (0.8 * prevI2);
                I1ForOddPrev3 = I1ForOddPrev2;
                I1ForOddPrev2 = detrender;
            }
            else
            {
                hilbertTempReal = A * smoothedValue;
                detrender = -detrender_Odd[hilbertIdx];
                detrender_Odd[hilbertIdx] = hilbertTempReal;
                detrender += hilbertTempReal;
                detrender -= prev_detrender_Odd;
                prev_detrender_Odd = B * prev_detrender_input_Odd;
                detrender += prev_detrender_Odd;
                prev_detrender_input_Odd = smoothedValue;
                detrender *= adjustedPrevPeriod;
                hilbertTempReal = A * detrender;
                Q1 = -Q1_Odd[hilbertIdx];
                Q1_Odd[hilbertIdx] = hilbertTempReal;
                Q1 += hilbertTempReal;
                Q1 -= prevQ1Odd;
                prevQ1Odd = B * prev_Q1_input_Odd;
                Q1 += prevQ1Odd;
                prev_Q1_input_Odd = detrender;
                Q1 *= adjustedPrevPeriod;
                hilbertTempReal = A * I1ForOddPrev3;
                jI = -jI_Odd[hilbertIdx];
                jI_Odd[hilbertIdx] = hilbertTempReal;
                jI += hilbertTempReal;
                jI -= prev_jI_Odd;
                prev_jI_Odd = B * prev_jI_input_Odd;
                jI += prev_jI_Odd;
                prev_jI_input_Odd = I1ForOddPrev3;
                jI *= adjustedPrevPeriod;
                hilbertTempReal = A * Q1;
                jQ = -jQ_Odd[hilbertIdx];
                jQ_Odd[hilbertIdx] = hilbertTempReal;
                jQ += hilbertTempReal;
                jQ -= prev_jQ_Odd;
                prev_jQ_Odd = B * prev_jQ_input_Odd;
                jQ += prev_jQ_Odd;
                prev_jQ_input_Odd = Q1;
                jQ *= adjustedPrevPeriod;
                Q2 = (0.2 * (Q1 + jI)) + (0.8 * prevQ2);
                I2 = (0.2 * (I1ForOddPrev3 - jQ)) + (0.8 * prevI2);
                I1ForEvenPrev3 = I1ForEvenPrev2;
                I1ForEvenPrev2 = detrender;
            }

            Re = (0.2 * ((I2 * prevI2) + (Q2 * prevQ2))) + (0.8 * Re);
            Im = (0.2 * ((I2 * prevQ2) - (Q2 * prevI2))) + (0.8 * Im);
            prevQ2 = Q2;
            prevI2 = I2;
            tempReal = period;
            if (Im != 0.0 && Re != 0.0)
            {
                period = 360.0 / (Math.Atan(Im / Re) * rad2Deg);
            }

            double tempReal2 = 1.5 * tempReal;
            if (period > tempReal2)
            {
                period = tempReal2;
            }

            tempReal2 = 0.67 * tempReal;
            if (period < tempReal2)
            {
                period = tempReal2;
            }

            period = period switch
            {
                < 6.0 => 6.0,
                > 50.0 => 50.0,
                _ => period
            };

            period = (0.2 * period) + (0.8 * tempReal);
            smoothPeriod = (0.33 * period) + (0.67 * smoothPeriod);
            prevDCPhase = DCPhase;
            double DCPeriod = smoothPeriod + 0.5;
            int DCPeriodInt = (int)DCPeriod;
            double realPart = 0.0;
            double imagPart = 0.0;
            int idx = smoothPrice_Idx;
            i = 0;
            while (i < DCPeriodInt)
            {
                tempReal = i * constDeg2RadBy360 / DCPeriodInt;
                tempReal2 = smoothPrice[idx];
                realPart += Math.Sin(tempReal) * tempReal2;
                imagPart += Math.Cos(tempReal) * tempReal2;
                if (idx == 0)
                {
                    idx = 49;
                }
                else
                {
                    idx--;
                }

                i++;
            }

            tempReal = Math.Abs(imagPart);
            if (tempReal > 0.0)
            {
                DCPhase = Math.Atan(realPart / imagPart) * rad2Deg;
            }
            else if (tempReal <= 0.01)
            {
                if (realPart < 0.0)
                {
                    DCPhase -= 90.0;
                }
                else if (realPart > 0.0)
                {
                    DCPhase += 90.0;
                }
            }

            DCPhase += 90.0;
            DCPhase += 360.0 / smoothPeriod;
            if (imagPart < 0.0)
            {
                DCPhase += 180.0;
            }

            if (DCPhase > 315.0)
            {
                DCPhase -= 360.0;
            }

            prevSine = sine;
            prevLeadSine = leadSine;
            sine = Math.Sin(DCPhase * deg2Rad);
            leadSine = Math.Sin((DCPhase + 45.0) * deg2Rad);
            DCPeriod = smoothPeriod + 0.5;
            DCPeriodInt = (int)DCPeriod;
            idx = today;
            tempReal = 0.0;
            for (i = 0; i < DCPeriodInt; i++)
            {
                tempReal += inReal[idx];
                idx--;
            }

            if (DCPeriodInt > 0)
            {
                tempReal /= DCPeriodInt;
            }

            double trendline = ((4.0 * tempReal) + (3.0 * iTrend1) + (2.0 * iTrend2) + iTrend3) / 10.0;
            iTrend3 = iTrend2;
            iTrend2 = iTrend1;
            iTrend1 = tempReal;
            int trend = 1;
            if (sine > leadSine && prevSine <= prevLeadSine
                || sine < leadSine && prevSine >= prevLeadSine)
            {
                daysInTrend = 0;
                trend = 0;
            }

            daysInTrend++;
            if (daysInTrend < 0.5 * smoothPeriod)
            {
                trend = 0;
            }

            tempReal = DCPhase - prevDCPhase;
            if (smoothPeriod != 0.0 && tempReal > 241.20000000000002 / smoothPeriod
                                    && tempReal < 540.0 / smoothPeriod)
            {
                trend = 0;
            }

            tempReal = smoothPrice[smoothPrice_Idx];
            if (trendline != 0.0 && Math.Abs((tempReal - trendline) / trendline) >= 0.015)
            {
                trend = 1;
            }

            if (today >= startIdx)
            {
                outInteger[outIdx] = trend;
                outIdx++;
            }

            smoothPrice_Idx++;
            if (smoothPrice_Idx > maxIdx_smoothPrice)
            {
                smoothPrice_Idx = 0;
            }

            today++;
        }
    }

    /// <summary>
    /// Returns the lookback period required for Hilbert Transform - Trend vs Cycle Mode calculation.
    /// </summary>
    /// <returns>The number of historical data points required before the first valid HT-Trend Mode value can be calculated.</returns>
    /// <remarks>
    /// The lookback period consists of:
    /// - Base period: 63 bars (required for Hilbert Transform calculations and smoothing)
    /// - Unstable period: Additional bars configured for HtTrendMode function
    /// 
    /// The total lookback ensures sufficient data for:
    /// - Weighted moving average smoothing (4 periods)
    /// - Hilbert Transform decomposition
    /// - Dominant cycle period and phase calculations
    /// - Trendline computation
    /// - Mode determination logic
    /// 
    /// This is one of the indicators with the longest lookback requirements due to its
    /// complex signal processing algorithms and need for stable cycle measurements.
    /// </remarks>
    public static int HtTrendModeLookback()
    {
        return (int)TACore.Globals.UnstablePeriod[FuncUnstId.HtTrendMode] + 63;
    }
}
