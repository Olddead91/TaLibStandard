#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## MinusDIResult Class

Represents the result of the Minus Directional Indicator \(\-DI\) calculation\.
\-DI is part of the Directional Movement System and measures the strength of downward price movements\.

```csharp
public record MinusDIResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.MinusDIResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; MinusDIResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[MinusDIResult](MinusDIResult.md 'TechnicalAnalysis\.Functions\.MinusDIResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [MinusDIResult\(RetCode, int, int, double\[\]\)](MinusDIResult.MinusDIResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.MinusDIResult\.MinusDIResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [MinusDIResult](MinusDIResult.md 'TechnicalAnalysis\.Functions\.MinusDIResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](MinusDIResult.Real.md 'TechnicalAnalysis\.Functions\.MinusDIResult\.Real') | Gets the array of Minus Directional Indicator values\. Values range from 0 to 100, representing the strength of downward price movement\. When \-DI is above \+DI, it suggests a downtrend; the wider the gap, the stronger the trend\. |
