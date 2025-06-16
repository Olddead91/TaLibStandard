#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## CeilResult Class

Represents the result of the vector ceiling operation \(CEIL function\)\.

```csharp
public record CeilResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.CeilResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; CeilResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[CeilResult](CeilResult.md 'TechnicalAnalysis\.Functions\.CeilResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
The CEIL function calculates the ceiling of each element in the input array\.
The ceiling of a number is the smallest integer that is greater than or equal to that number\.
For example, ceil\(2\.3\) = 3, ceil\(\-2\.3\) = \-2, ceil\(5\.0\) = 5\.

| Constructors | |
| :--- | :--- |
| [CeilResult\(RetCode, int, int, double\[\]\)](CeilResult.CeilResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.CeilResult\.CeilResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [CeilResult](CeilResult.md 'TechnicalAnalysis\.Functions\.CeilResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](CeilResult.Real.md 'TechnicalAnalysis\.Functions\.CeilResult\.Real') | Gets the array of ceiling values resulting from the CEIL operation\. |
