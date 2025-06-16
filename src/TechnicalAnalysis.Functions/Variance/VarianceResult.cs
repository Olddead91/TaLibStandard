// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

/// <summary>
/// Represents the result of the Variance indicator calculation.
/// Variance is a statistical measure of volatility that represents the squared deviations from the mean price.
/// </summary>
public record VarianceResult : IndicatorResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VarianceResult"/> class.
    /// </summary>
    /// <param name="retCode">The return code indicating the success or failure of the calculation.</param>
    /// <param name="begIdx">The index of the first valid data point in the output array.</param>
    /// <param name="nbElement">The number of valid data points in the output array.</param>
    /// <param name="real">The array containing the calculated variance values.</param>
    public VarianceResult(RetCode retCode, int begIdx, int nbElement, double[] real)
        : base(retCode, begIdx, nbElement)
    {
        Real = real;
    }

    /// <summary>
    /// Gets the array of Variance values.
    /// Each value represents the average of the squared differences from the mean.
    /// Variance is the square of standard deviation and provides a measure of price dispersion.
    /// </summary>
    public double[] Real { get; }
}
