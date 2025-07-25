﻿// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAMath
{
    /// <summary>
    /// Calculates the natural logarithm (base e) for each element in the input array.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation within the array.</param>
    /// <param name="endIdx">The ending index for the calculation within the array.</param>
    /// <param name="real">An array of real values to calculate the natural logarithm for.</param>
    /// <returns>
    /// A <see cref="LnResult"/> containing the calculated natural logarithm values, 
    /// along with the starting index of the result and the number of elements generated.
    /// </returns>
    /// <remarks>
    /// The natural logarithm is the logarithm to the base e (approximately 2.71828).
    /// This function is undefined for negative values and zero, which may result in NaN or negative infinity.
    /// In technical analysis, logarithmic transformations are often used to normalize data or analyze
    /// percentage changes in price movements.
    /// </remarks>
    public static LnResult Ln(int startIdx, int endIdx, double[] real)
    {
        int outBegIdx = default;
        int outNBElement = default;
        double[] outReal = new double[endIdx - startIdx + 1];

        RetCode retCode = TAFunc.Ln(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, ref outReal);
            
        return new LnResult(retCode, outBegIdx, outNBElement, outReal);
    }

    /// <summary>
    /// Calculates the natural logarithm (base e) for each element in the input array.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation within the array.</param>
    /// <param name="endIdx">The ending index for the calculation within the array.</param>
    /// <param name="real">An array of real values to calculate the natural logarithm for.</param>
    /// <returns>
    /// A <see cref="LnResult"/> containing the calculated natural logarithm values, 
    /// along with the starting index of the result and the number of elements generated.
    /// </returns>
    /// <remarks>
    /// This overload accepts float values for convenience and internally converts them to double precision
    /// before performing the calculation. This may result in minor precision differences compared to 
    /// using double values directly.
    /// </remarks>
    public static LnResult Ln(int startIdx, int endIdx, float[] real)
        => Ln(startIdx, endIdx, real.ToDouble());
}
