// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

/// <summary>
/// Represents the result of the Plus Directional Movement (+DM) indicator calculation.
/// +DM measures upward price movement and is used as a component in calculating the Directional Movement System indicators.
/// </summary>
public record PlusDMResult : IndicatorResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlusDMResult"/> class.
    /// </summary>
    /// <param name="retCode">The return code indicating the success or failure of the calculation.</param>
    /// <param name="begIdx">The index of the first valid data point in the output array.</param>
    /// <param name="nbElement">The number of valid data points in the output array.</param>
    /// <param name="real">The array containing the calculated +DM values.</param>
    public PlusDMResult(RetCode retCode, int begIdx, int nbElement, double[] real)
        : base(retCode, begIdx, nbElement)
    {
        Real = real;
    }

    /// <summary>
    /// Gets the array of Plus Directional Movement values.
    /// Each value represents the positive (upward) directional movement for the period.
    /// Calculated as the difference between current high and previous high when it's positive and greater than the downward movement.
    /// </summary>
    public double[] Real { get; }
}
