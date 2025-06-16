// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

/// <summary>
/// Represents the result of the vector hyperbolic cosine operation (COSH function).
/// </summary>
/// <remarks>
/// The COSH function calculates the hyperbolic cosine of each element in the input array.
/// The hyperbolic cosine is defined as cosh(x) = (e^x + e^(-x)) / 2.
/// The result values are always greater than or equal to 1.
/// </remarks>
public record CoshResult : IndicatorResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CoshResult"/> class.
    /// </summary>
    /// <param name="retCode">The return code indicating the success or failure of the calculation.</param>
    /// <param name="begIdx">The index of the first valid data point in the output array.</param>
    /// <param name="nbElement">The number of valid data points in the output array.</param>
    /// <param name="real">The array containing the hyperbolic cosine values.</param>
    public CoshResult(RetCode retCode, int begIdx, int nbElement, double[] real)
        : base(retCode, begIdx, nbElement)
    {
        Real = real;
    }

    /// <summary>
    /// Gets the array of hyperbolic cosine values resulting from the COSH operation.
    /// </summary>
    /// <value>
    /// An array of doubles where each element represents the hyperbolic cosine
    /// of the corresponding element from the input array.
    /// </value>
    public double[] Real { get; }
}
