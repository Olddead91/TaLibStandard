#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions')

## AtanResult Class

Represents the result of the vector arctangent operation \(ATAN function\)\.

```csharp
public record AtanResult : TechnicalAnalysis.Common.IndicatorResult, System.IEquatable<TechnicalAnalysis.Functions.AtanResult>
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.IndicatorResult](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.IndicatorResult 'TechnicalAnalysis\.Common\.IndicatorResult') &#129106; AtanResult

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[AtanResult](AtanResult.md 'TechnicalAnalysis\.Functions\.AtanResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

### Remarks
The ATAN function calculates the arctangent \(inverse tangent\) of each element in the input array\.
The result is an array of angles in radians, where each element represents the arctangent
of the corresponding input value\. The output range is \(\-π/2, π/2\)\.

| Constructors | |
| :--- | :--- |
| [AtanResult\(RetCode, int, int, double\[\]\)](AtanResult.AtanResult(RetCode,int,int,double[]).md 'TechnicalAnalysis\.Functions\.AtanResult\.AtanResult\(TechnicalAnalysis\.Common\.RetCode, int, int, double\[\]\)') | Initializes a new instance of the [AtanResult](AtanResult.md 'TechnicalAnalysis\.Functions\.AtanResult') class\. |

| Properties | |
| :--- | :--- |
| [Real](AtanResult.Real.md 'TechnicalAnalysis\.Functions\.AtanResult\.Real') | Gets the array of arctangent values resulting from the ATAN operation\. |
