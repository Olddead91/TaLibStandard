﻿// Copyright (c) 2023 Philippe Matray. All rights reserved.
// This file is part of TaLibStandard.
// TaLibStandard is licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for the full license text.
// For more information, visit https://github.com/phmatray/TaLibStandard.

namespace TechnicalAnalysis.Functions;

/// <summary>
/// Represents the result of an Acos (Arc Cosine) calculation.
/// </summary>
public record AcosResult : IndicatorResult
{
    /// <summary>
    /// Initializes a new instance of the AcosResult record.
    /// </summary>
    /// <param name="retCode">The return code indicating the success or failure of the calculation.</param>
    /// <param name="begIdx">The index of the first valid output value.</param>
    /// <param name="nbElement">The number of valid output elements.</param>
    /// <param name="real">The array of calculated arc cosine values in radians.</param>
    public AcosResult(RetCode retCode, int begIdx, int nbElement, double[] real)
        : base(retCode, begIdx, nbElement)
    {
        Real = real;
    }

    /// <summary>
    /// Gets the array of calculated arc cosine values in radians.
    /// </summary>
    public double[] Real { get; }
}
