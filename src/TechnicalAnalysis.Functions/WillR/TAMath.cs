﻿// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAMath
{
    /// <summary>
    /// Calculates the Williams' %R (WILLR) indicator.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">An array of high prices.</param>
    /// <param name="low">An array of low prices.</param>
    /// <param name="close">An array of closing prices.</param>
    /// <param name="timePeriod">The number of periods for the calculation (default: 14).</param>
    /// <returns>A WillRResult object containing the calculated values.</returns>
    /// <remarks>
    /// Williams' %R is a momentum indicator that measures overbought and oversold levels.
    /// It reflects the level of the close relative to the highest high for the look-back period.
    /// The oscillator ranges from -100 to 0, with readings from 0 to -20 considered overbought,
    /// and readings from -80 to -100 considered oversold.
    /// </remarks>
    public static WillRResult WillR(
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

        RetCode retCode = TAFunc.WillR(
            startIdx,
            endIdx,
            high,
            low,
            close,
            timePeriod,
            ref outBegIdx,
            ref outNBElement,
            ref outReal);
            
        return new WillRResult(retCode, outBegIdx, outNBElement, outReal);
    }

    /// <summary>
    /// Calculates the Williams' %R (WILLR) indicator using the default time period.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">An array of high prices.</param>
    /// <param name="low">An array of low prices.</param>
    /// <param name="close">An array of closing prices.</param>
    /// <returns>A WillRResult object containing the calculated values.</returns>
    /// <remarks>Uses the default time period of 14.</remarks>
    public static WillRResult WillR(int startIdx, int endIdx, double[] high, double[] low, double[] close)
        => WillR(startIdx, endIdx, high, low, close, 14);

    /// <summary>
    /// Calculates the Williams' %R (WILLR) indicator using float arrays.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">An array of high prices.</param>
    /// <param name="low">An array of low prices.</param>
    /// <param name="close">An array of closing prices.</param>
    /// <param name="timePeriod">The number of periods for the calculation.</param>
    /// <returns>A WillRResult object containing the calculated values.</returns>
    /// <remarks>
    /// This overload accepts float arrays and converts them to double arrays before processing.
    /// This may result in a minor performance overhead due to the conversion process.
    /// </remarks>
    public static WillRResult WillR(int startIdx, int endIdx, float[] high, float[] low, float[] close, int timePeriod)
        => WillR(startIdx, endIdx, high.ToDouble(), low.ToDouble(), close.ToDouble(), timePeriod);
        
    /// <summary>
    /// Calculates the Williams' %R (WILLR) indicator using float arrays and the default time period.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation.</param>
    /// <param name="endIdx">The ending index for the calculation.</param>
    /// <param name="high">An array of high prices.</param>
    /// <param name="low">An array of low prices.</param>
    /// <param name="close">An array of closing prices.</param>
    /// <returns>A WillRResult object containing the calculated values.</returns>
    /// <remarks>
    /// Uses the default time period of 14. This overload accepts float arrays and converts them to double arrays.
    /// </remarks>
    public static WillRResult WillR(int startIdx, int endIdx, float[] high, float[] low, float[] close)
        => WillR(startIdx, endIdx, high, low, close, 14);
}
