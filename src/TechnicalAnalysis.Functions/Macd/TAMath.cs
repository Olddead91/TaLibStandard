﻿// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAMath
{
    /// <summary>
    /// Calculates the Moving Average Convergence Divergence (MACD) indicator.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">Array of input values (usually closing prices).</param>
    /// <param name="optInFastPeriod">The number of periods for the fast EMA (default: 12).</param>
    /// <param name="optInSlowPeriod">The number of periods for the slow EMA (default: 26).</param>
    /// <param name="optInSignalPeriod">The number of periods for the signal line EMA (default: 9).</param>
    /// <returns>A MacdResult containing the MACD line, signal line, and histogram values.</returns>
    /// <remarks>
    /// The MACD is a trend-following momentum indicator that shows the relationship between two moving averages.
    /// - MACD Line: 12-period EMA - 26-period EMA
    /// - Signal Line: 9-period EMA of MACD Line
    /// - MACD Histogram: MACD Line - Signal Line
    /// </remarks>
    public static MacdResult Macd(
        int startIdx,
        int endIdx,
        double[] real,
        int optInFastPeriod,
        int optInSlowPeriod,
        int optInSignalPeriod)
    {
        int outBegIdx = 0;
        int outNBElement = 0;
        double[] outMACD = new double[endIdx - startIdx + 1];
        double[] outMACDSignal = new double[endIdx - startIdx + 1];
        double[] outMACDHist = new double[endIdx - startIdx + 1];

        RetCode retCode = TAFunc.Macd(
            startIdx,
            endIdx,
            real,
            optInFastPeriod,
            optInSlowPeriod,
            optInSignalPeriod,
            ref outBegIdx,
            ref outNBElement,
            ref outMACD,
            ref outMACDSignal,
            ref outMACDHist);
            
        return new MacdResult(retCode, outBegIdx, outNBElement, outMACD, outMACDSignal, outMACDHist);
    }

    /// <summary>
    /// Calculates the Moving Average Convergence Divergence (MACD) indicator using default parameters.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">Array of input values (usually closing prices).</param>
    /// <returns>A MacdResult containing the MACD line, signal line, and histogram values.</returns>
    /// <remarks>
    /// Uses default values: fastPeriod=12, slowPeriod=26, signalPeriod=9.
    /// </remarks>
    public static MacdResult Macd(int startIdx, int endIdx, double[] real)
        => Macd(startIdx, endIdx, real, 12, 26, 9);

    /// <summary>
    /// Calculates the Moving Average Convergence Divergence (MACD) indicator.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">Array of input values (usually closing prices).</param>
    /// <param name="optInFastPeriod">The number of periods for the fast EMA.</param>
    /// <param name="optInSlowPeriod">The number of periods for the slow EMA.</param>
    /// <param name="optInSignalPeriod">The number of periods for the signal line EMA.</param>
    /// <returns>A MacdResult containing the MACD line, signal line, and histogram values.</returns>
    /// <remarks>
    /// This overload accepts float arrays and converts them to double arrays for calculation.
    /// </remarks>
    public static MacdResult Macd(
        int startIdx,
        int endIdx,
        float[] real,
        int optInFastPeriod,
        int optInSlowPeriod,
        int optInSignalPeriod)
        => Macd(startIdx, endIdx, real.ToDouble(), optInFastPeriod, optInSlowPeriod, optInSignalPeriod);
        
    /// <summary>
    /// Calculates the Moving Average Convergence Divergence (MACD) indicator using default parameters.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">Array of input values (usually closing prices).</param>
    /// <returns>A MacdResult containing the MACD line, signal line, and histogram values.</returns>
    /// <remarks>
    /// This overload accepts float arrays and converts them to double arrays for calculation.
    /// Uses default values: fastPeriod=12, slowPeriod=26, signalPeriod=9.
    /// </remarks>
    public static MacdResult Macd(int startIdx, int endIdx, float[] real)
        => Macd(startIdx, endIdx, real, 12, 26, 9);
}
