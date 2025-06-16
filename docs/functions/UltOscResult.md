#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## UltOscResult Class

Represents the result of calculating the Ultimate Oscillator \(UltOsc\) indicator\.

```csharp
public record UltOscResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.UltOscResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; UltOscResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[UltOscResult](UltOscResult.md 'TechnicalAnalysis\.Functions\.UltOscResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
The Ultimate Oscillator is a momentum oscillator designed to capture momentum across three different timeframes\.
It combines short\-term \(7 periods\), intermediate\-term \(14 periods\), and long\-term \(28 periods\) market cycles
to reduce false signals and provide more reliable overbought/oversold readings\.

| Constructors | |
| :--- | :--- |
| [UltOscResult\(RetCode, int, int, double\[\]\)](UltOscResult.UltOscResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.UltOscResult\.UltOscResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [UltOscResult](UltOscResult.md 'TechnicalAnalysis\.Functions\.UltOscResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](UltOscResult.Real.md 'TechnicalAnalysis\.Functions\.UltOscResult\.Real') | Gets the array of Ultimate Oscillator values\. |
