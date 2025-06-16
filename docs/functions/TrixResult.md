#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## TrixResult Class

Represents the result of calculating the TRIX indicator\.

```csharp
public record TrixResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.TrixResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; TrixResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[TrixResult](TrixResult.md 'TechnicalAnalysis\.Functions\.TrixResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
TRIX is a momentum oscillator that displays the rate of change of a triple exponentially smoothed moving average\.
It filters out insignificant price movements and helps identify oversold and overbought markets\.
The indicator oscillates around a zero line and is excellent for identifying divergences\.

| Constructors | |
| :--- | :--- |
| [TrixResult\(RetCode, int, int, double\[\]\)](TrixResult.TrixResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.TrixResult\.TrixResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [TrixResult](TrixResult.md 'TechnicalAnalysis\.Functions\.TrixResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](TrixResult.Real.md 'TechnicalAnalysis\.Functions\.TrixResult\.Real') | Gets the array of TRIX values\. |
