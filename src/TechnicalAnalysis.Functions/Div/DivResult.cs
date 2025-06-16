// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

/// <summary>
/// Represents the result of the vector division operation (DIV function).
/// </summary>
/// <remarks>
/// The DIV function performs element-wise division of two input arrays,
/// producing an output array where each element is the quotient of the corresponding
/// elements from the input arrays (first array divided by second array).
/// </remarks>
public record DivResult : IndicatorResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DivResult"/> class.
    /// </summary>
    /// <param name="retCode">The return code indicating the success or failure of the calculation.</param>
    /// <param name="begIdx">The index of the first valid data point in the output array.</param>
    /// <param name="nbElement">The number of valid data points in the output array.</param>
    /// <param name="real">The array containing the quotient values from the division operation.</param>
    public DivResult(RetCode retCode, int begIdx, int nbElement, double[] real)
        : base(retCode, begIdx, nbElement)
    {
        Real = real;
    }

    /// <summary>
    /// Gets the array of quotient values resulting from the element-wise division operation.
    /// </summary>
    /// <value>
    /// An array of doubles where each element represents the quotient of the corresponding
    /// elements from the two input arrays (first array divided by second array).
    /// </value>
    public double[] Real { get; }
}
