#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## PpoResult Class

Represents the result of calculating the Percentage Price Oscillator \(PPO\) indicator\.

```csharp
public record PpoResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.PpoResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; PpoResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[PpoResult](PpoResult.md 'TechnicalAnalysis\.Functions\.PpoResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
PPO displays the difference between two moving averages as a percentage of the slower moving average\.
This makes it easier to compare momentum across different securities or time periods,
as the values are normalized\. It is similar to MACD but expressed as a percentage\.

| Constructors | |
| :--- | :--- |
| [PpoResult\(RetCode, int, int, double\[\]\)](PpoResult.PpoResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.PpoResult\.PpoResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [PpoResult](PpoResult.md 'TechnicalAnalysis\.Functions\.PpoResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](PpoResult.Real.md 'TechnicalAnalysis\.Functions\.PpoResult\.Real') | Gets the array of percentage price oscillator values\. |
