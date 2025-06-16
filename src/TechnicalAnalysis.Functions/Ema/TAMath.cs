﻿// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAMath
{
    /// <summary>
    /// Calculates the Exponential Moving Average (EMA) for the specified range of data.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values.</param>
    /// <param name="timePeriod">The number of periods to use in the EMA calculation. Default is 30.</param>
    /// <returns>An EmaResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// The Exponential Moving Average gives more weight to recent prices, making it more responsive
    /// to new information compared to the Simple Moving Average. The EMA is calculated using a
    /// smoothing factor of 2/(timePeriod + 1).
    /// </remarks>
    public static EmaResult Ema(int startIdx, int endIdx, double[] real, int timePeriod)
    {
        int outBegIdx = default;
        int outNBElement = default;
        double[] outReal = new double[endIdx - startIdx + 1];

        RetCode retCode = TAFunc.Ema(startIdx, endIdx, real, timePeriod, ref outBegIdx, ref outNBElement, ref outReal);
            
        return new EmaResult(retCode, outBegIdx, outNBElement, outReal);
    }

    /// <summary>
    /// Calculates the Exponential Moving Average (EMA) using a default period of 30.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values.</param>
    /// <returns>An EmaResult object containing the calculated values and metadata.</returns>
    public static EmaResult Ema(int startIdx, int endIdx, double[] real)
        => Ema(startIdx, endIdx, real, 30);

    /// <summary>
    /// Calculates the Exponential Moving Average (EMA) for float input data.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values as floats.</param>
    /// <param name="timePeriod">The number of periods to use in the EMA calculation.</param>
    /// <returns>An EmaResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// This overload converts the float array to double array before performing the calculation,
    /// as the underlying TAFunc library operates on double precision values.
    /// </remarks>
    public static EmaResult Ema(int startIdx, int endIdx, float[] real, int timePeriod)
        => Ema(startIdx, endIdx, real.ToDouble(), timePeriod);
        
    /// <summary>
    /// Calculates the Exponential Moving Average (EMA) for float input data using a default period of 30.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values as floats.</param>
    /// <returns>An EmaResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// This overload converts the float array to double array before performing the calculation,
    /// as the underlying TAFunc library operates on double precision values.
    /// </remarks>
    public static EmaResult Ema(int startIdx, int endIdx, float[] real)
        => Ema(startIdx, endIdx, real, 30);
}
