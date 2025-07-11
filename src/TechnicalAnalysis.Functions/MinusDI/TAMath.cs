﻿// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAMath
{
    /// <summary>
    /// Calculates the Minus Directional Indicator (-DI) which measures the strength of negative price movement.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">Array of high prices.</param>
    /// <param name="low">Array of low prices.</param>
    /// <param name="close">Array of closing prices.</param>
    /// <param name="timePeriod">The number of periods to use in the calculation (default: 14).</param>
    /// <returns>A MinusDIResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// The Minus Directional Indicator is part of the Directional Movement System developed by Welles Wilder.
    /// It measures the strength of negative price movement and is typically used in conjunction with the
    /// Plus Directional Indicator (+DI) to identify trend direction and strength. When -DI is above +DI,
    /// it suggests a downward trend.
    /// </remarks>
    public static MinusDIResult MinusDI(
        int startIdx,
        int endIdx,
        double[] high,
        double[] low,
        double[] close,
        int timePeriod)
    {
        int outBegIdx = default;
        int outNBElement = default;
        double[] outReal = new double[endIdx - startIdx + 1];

        RetCode retCode = TAFunc.MinusDI(
            startIdx,
            endIdx,
            high,
            low,
            close,
            timePeriod,
            ref outBegIdx,
            ref outNBElement,
            ref outReal);
            
        return new MinusDIResult(retCode, outBegIdx, outNBElement, outReal);
    }

    /// <summary>
    /// Calculates the Minus Directional Indicator (-DI) using a default time period of 14.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">Array of high prices.</param>
    /// <param name="low">Array of low prices.</param>
    /// <param name="close">Array of closing prices.</param>
    /// <returns>A MinusDIResult object containing the calculated values and metadata.</returns>
    public static MinusDIResult MinusDI(int startIdx, int endIdx, double[] high, double[] low, double[] close)
        => MinusDI(startIdx, endIdx, high, low, close, 14);

    /// <summary>
    /// Calculates the Minus Directional Indicator (-DI) for float arrays.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">Array of high prices.</param>
    /// <param name="low">Array of low prices.</param>
    /// <param name="close">Array of closing prices.</param>
    /// <param name="timePeriod">The number of periods to use in the calculation (default: 14).</param>
    /// <returns>A MinusDIResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// This overload accepts float arrays and converts them to double arrays before performing the calculation.
    /// This ensures compatibility with data sources that provide float precision while maintaining accuracy
    /// in the calculations.
    /// </remarks>
    public static MinusDIResult MinusDI(
        int startIdx,
        int endIdx,
        float[] high,
        float[] low,
        float[] close,
        int timePeriod)
        => MinusDI(startIdx, endIdx, high.ToDouble(), low.ToDouble(), close.ToDouble(), timePeriod);

    /// <summary>
    /// Calculates the Minus Directional Indicator (-DI) for float arrays using a default time period of 14.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">Array of high prices.</param>
    /// <param name="low">Array of low prices.</param>
    /// <param name="close">Array of closing prices.</param>
    /// <returns>A MinusDIResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// This overload accepts float arrays and converts them to double arrays before performing the calculation.
    /// </remarks>
    public static MinusDIResult MinusDI(int startIdx, int endIdx, float[] high, float[] low, float[] close)
        => MinusDI(startIdx, endIdx, high, low, close, 14);
}
