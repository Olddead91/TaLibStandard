#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## HtPhasorResult Class

Represents the result of the Hilbert Transform \- Phasor Components \(HT\_PHASOR\) calculation\.
This indicator decomposes price data into its in\-phase and quadrature components using Hilbert Transform,
providing a complex representation of market cycles for advanced signal processing\.

```csharp
public record HtPhasorResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.HtPhasorResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; HtPhasorResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[HtPhasorResult](HtPhasorResult.md 'TechnicalAnalysis\.Functions\.HtPhasorResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [HtPhasorResult\(RetCode, int, int, double\[\], double\[\]\)](HtPhasorResult.HtPhasorResult(RetCode,int,int,double[],double[]).md 'TechnicalAnalysis\.Functions\.HtPhasorResult\.HtPhasorResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\], double\[\]\)') | Initializes a new instance of the [HtPhasorResult](HtPhasorResult.md 'TechnicalAnalysis\.Functions\.HtPhasorResult') class\. |

| Properties | |
| :--- | :--- |
| [InPhase](HtPhasorResult.InPhase.md 'TechnicalAnalysis\.Functions\.HtPhasorResult\.InPhase') | Gets the array of in\-phase component values\. The in\-phase component represents the real part of the Hilbert Transform output, aligned with the original signal's phase\. |
| [Quadrature](HtPhasorResult.Quadrature.md 'TechnicalAnalysis\.Functions\.HtPhasorResult\.Quadrature') | Gets the array of quadrature component values\. The quadrature component represents the imaginary part of the Hilbert Transform output, phase\-shifted by 90 degrees from the original signal\. |
