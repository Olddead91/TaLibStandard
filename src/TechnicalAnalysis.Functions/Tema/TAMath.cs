﻿// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAMath
{
    /// <summary>
    /// Calculates the Triple Exponential Moving Average (TEMA) for the specified range of data.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values.</param>
    /// <param name="timePeriod">The number of periods to use in the TEMA calculation. Default is 30.</param>
    /// <returns>A TemaResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// The Triple Exponential Moving Average (TEMA) was developed by Patrick Mulloy to reduce the lag
    /// inherent in moving averages. It uses a combination of a single, double, and triple exponential
    /// moving average. The formula is: TEMA = 3*EMA - 3*EMA(EMA) + EMA(EMA(EMA)).
    /// TEMA is more responsive to price changes than DEMA or traditional moving averages.
    /// </remarks>
    public static TemaResult Tema(int startIdx, int endIdx, double[] real, int timePeriod)
    {
        int outBegIdx = default;
        int outNBElement = default;
        double[] outReal = new double[endIdx - startIdx + 1];

        RetCode retCode = TAFunc.Tema(startIdx, endIdx, real, timePeriod, ref outBegIdx, ref outNBElement, ref outReal);
            
        return new TemaResult(retCode, outBegIdx, outNBElement, outReal);
    }

    /// <summary>
    /// Calculates the Triple Exponential Moving Average (TEMA) using a default period of 30.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values.</param>
    /// <returns>A TemaResult object containing the calculated values and metadata.</returns>
    public static TemaResult Tema(int startIdx, int endIdx, double[] real)
        => Tema(startIdx, endIdx, real, 30);

    /// <summary>
    /// Calculates the Triple Exponential Moving Average (TEMA) for float input data.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values as floats.</param>
    /// <param name="timePeriod">The number of periods to use in the TEMA calculation.</param>
    /// <returns>A TemaResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// This overload converts the float array to double array before performing the calculation,
    /// as the underlying TAFunc library operates on double precision values.
    /// </remarks>
    public static TemaResult Tema(int startIdx, int endIdx, float[] real, int timePeriod)
        => Tema(startIdx, endIdx, real.ToDouble(), timePeriod);
        
    /// <summary>
    /// Calculates the Triple Exponential Moving Average (TEMA) for float input data using a default period of 30.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation range.</param>
    /// <param name="endIdx">The ending index for the calculation range.</param>
    /// <param name="real">The input data array containing price values as floats.</param>
    /// <returns>A TemaResult object containing the calculated values and metadata.</returns>
    /// <remarks>
    /// This overload converts the float array to double array before performing the calculation,
    /// as the underlying TAFunc library operates on double precision values.
    /// </remarks>
    public static TemaResult Tema(int startIdx, int endIdx, float[] real)
        => Tema(startIdx, endIdx, real, 30);
}
