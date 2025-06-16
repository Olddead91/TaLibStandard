#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## EmaResult Class

Represents the result of calculating the Exponential Moving Average \(EMA\) indicator\.

```csharp
public record EmaResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.EmaResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; EmaResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[EmaResult](EmaResult.md 'TechnicalAnalysis\.Functions\.EmaResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
The EMA is a type of moving average that gives more weight to recent prices,
making it more responsive to new information compared to the Simple Moving Average \(SMA\)\.
It is commonly used to identify trends and generate trading signals\.

| Constructors | |
| :--- | :--- |
| [EmaResult\(RetCode, int, int, double\[\]\)](EmaResult.EmaResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.EmaResult\.EmaResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [EmaResult](EmaResult.md 'TechnicalAnalysis\.Functions\.EmaResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](EmaResult.Real.md 'TechnicalAnalysis\.Functions\.EmaResult\.Real') | Gets the array of exponential moving average values\. |
