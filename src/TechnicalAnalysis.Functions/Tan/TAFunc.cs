// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

public static partial class TAFunc
{
    /// <summary>
    /// Calculates the trigonometric tangent of input values.
    /// </summary>
    /// <param name="startIdx">The starting index for the calculation within the input array.</param>
    /// <param name="endIdx">The ending index for the calculation within the input array.</param>
    /// <param name="inReal">Input array of values (in radians).</param>
    /// <param name="outBegIdx">The index of the first valid output value.</param>
    /// <param name="outNBElement">The number of valid output elements.</param>
    /// <param name="outReal">Output array containing the tangent of each input value.</param>
    /// <returns>A RetCode indicating the success or failure of the calculation.</returns>
    /// <remarks>
    /// This function calculates:
    /// outReal[i] = tan(inReal[i])
    /// 
    /// Input values are expected to be in radians.
    /// Output values can range from negative to positive infinity.
    /// 
    /// Note: Tangent has discontinuities at odd multiples of π/2 where it approaches ±infinity.
    /// 
    /// Common uses in technical analysis:
    /// - Advanced cycle analysis
    /// - Angle calculations in geometric charting
    /// - Slope and rate of change transformations
    /// - Specialized momentum indicators
    /// </remarks>
    public static RetCode Tan(
        int startIdx,
        int endIdx,
        in double[] inReal,
        ref int outBegIdx,
        ref int outNBElement,
        ref double[] outReal)
    {
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

        if (outReal == null!)
        {
            return BadParam;
        }

        int i = startIdx;
        int outIdx = 0;
        while (i <= endIdx)
        {
            outReal[outIdx] = Math.Tan(inReal[i]);
            i++;
            outIdx++;
        }

        outNBElement = outIdx;
        outBegIdx = startIdx;
        return Success;
    }

    /// <summary>
    /// Returns the lookback period required for Tan calculation.
    /// </summary>
    /// <returns>Always returns 0 as tangent calculation requires no historical data.</returns>
    public static int TanLookback()
    {
        return 0;
    }
}
