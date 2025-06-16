#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## LnResult Class

Represents the result of the vector natural logarithm operation \(LN function\)\.

```csharp
public record LnResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.LnResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; LnResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[LnResult](LnResult.md 'TechnicalAnalysis\.Functions\.LnResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
The LN function calculates the natural logarithm \(base e\) of each element in the input array\.
The natural logarithm is the inverse of the exponential function\. Input values must be positive\.
For example, ln\(e\) = 1, ln\(1\) = 0\.

| Constructors | |
| :--- | :--- |
| [LnResult\(RetCode, int, int, double\[\]\)](LnResult.LnResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.LnResult\.LnResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [LnResult](LnResult.md 'TechnicalAnalysis\.Functions\.LnResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](LnResult.Real.md 'TechnicalAnalysis\.Functions\.LnResult\.Real') | Gets the array of natural logarithm values resulting from the LN operation\. |
