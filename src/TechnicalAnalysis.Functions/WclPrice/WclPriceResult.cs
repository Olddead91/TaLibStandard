// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

/// <summary>
/// Represents the result of the Weighted Close Price calculation.
/// </summary>
/// <remarks>
/// The Weighted Close Price emphasizes the closing price by giving it more weight in the 
/// calculation compared to the high and low prices. It is calculated as: (High + Low + Close + Close) / 4. 
/// This price transformation assumes that the closing price is the most important price of 
/// the trading period, as it represents the final consensus of value for that period. 
/// The weighted close is often used in trend-following strategies and as input for other indicators.
/// </remarks>
public record WclPriceResult : IndicatorResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WclPriceResult"/> class.
    /// </summary>
    /// <param name="retCode">The return code indicating the success or failure of the calculation.</param>
    /// <param name="begIdx">The index of the first valid data point in the output array.</param>
    /// <param name="nbElement">The number of valid data points in the output array.</param>
    /// <param name="real">The array containing the calculated weighted close price values.</param>
    public WclPriceResult(RetCode retCode, int begIdx, int nbElement, double[] real)
        : base(retCode, begIdx, nbElement)
    {
        Real = real;
    }

    /// <summary>
    /// Gets the array of weighted close price values.
    /// </summary>
    /// <value>
    /// An array of doubles representing the weighted close price for each period, 
    /// calculated with double weight on the closing price. This emphasizes the importance 
    /// of the closing price while still considering the full trading range, making it 
    /// useful for trend analysis and momentum studies.
    /// </value>
    public double[] Real { get; }
}
