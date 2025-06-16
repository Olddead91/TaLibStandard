#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## MinResult Class

Represents the result of calculating the lowest values over a specified period\.
The MIN function identifies the minimum value within a rolling window of data points\.

```csharp
public record MinResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.MinResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; MinResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[MinResult](MinResult.md 'TechnicalAnalysis\.Functions\.MinResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [MinResult\(RetCode, int, int, double\[\]\)](MinResult.MinResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.MinResult\.MinResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [MinResult](MinResult.md 'TechnicalAnalysis\.Functions\.MinResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](MinResult.Real.md 'TechnicalAnalysis\.Functions\.MinResult\.Real') | Gets the array of minimum values\. Each value represents the lowest data point within the specified rolling period\. |
