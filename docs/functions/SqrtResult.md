#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## SqrtResult Class

Represents the result of the vector square root operation \(SQRT function\)\.

```csharp
public record SqrtResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.SqrtResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; SqrtResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[SqrtResult](SqrtResult.md 'TechnicalAnalysis\.Functions\.SqrtResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
The SQRT function calculates the square root of each element in the input array\.
Input values must be non\-negative \(zero or positive\)\. The square root is the value that,
when multiplied by itself, gives the original number\. For example, sqrt\(4\) = 2, sqrt\(9\) = 3\.

| Constructors | |
| :--- | :--- |
| [SqrtResult\(RetCode, int, int, double\[\]\)](SqrtResult.SqrtResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.SqrtResult\.SqrtResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [SqrtResult](SqrtResult.md 'TechnicalAnalysis\.Functions\.SqrtResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](SqrtResult.Real.md 'TechnicalAnalysis\.Functions\.SqrtResult\.Real') | Gets the array of square root values resulting from the SQRT operation\. |
