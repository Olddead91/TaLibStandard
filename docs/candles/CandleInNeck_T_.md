#### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md 'Atypical\.TechnicalAnalysis\.Candles')
### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md#TechnicalAnalysis.Candles 'TechnicalAnalysis\.Candles')

## CandleInNeck\<T\> Class

In\-Neck Pattern \(Pattern Recognition\)

```csharp
public class CandleInNeck<T> : TechnicalAnalysis.Common.CandleIndicator<T>
    where T : System.Numerics.IFloatingPoint<T>
```
#### Type parameters

<a name='TechnicalAnalysis.Candles.CandleInNeck_T_.T'></a>

`T`

The type of the array elements\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.CandleIndicator&lt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1')[T](CandleInNeck_T_.md#TechnicalAnalysis.Candles.CandleInNeck_T_.T 'TechnicalAnalysis\.Candles\.CandleInNeck\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1') &#129106; CandleInNeck\<T\>

| Constructors | |
| :--- | :--- |
| [CandleInNeck\(T\[\], T\[\], T\[\], T\[\]\)](CandleInNeck_T_.CandleInNeck(T[],T[],T[],T[]).md 'TechnicalAnalysis\.Candles\.CandleInNeck\<T\>\.CandleInNeck\(T\[\], T\[\], T\[\], T\[\]\)') | In\-Neck Pattern \(Pattern Recognition\) |

| Methods | |
| :--- | :--- |
| [Compute\(int, int\)](CandleInNeck_T_.Compute(int,int).md 'TechnicalAnalysis\.Candles\.CandleInNeck\<T\>\.Compute\(int, int\)') | Computes the [CandleInNeck&lt;T&gt;](CandleInNeck_T_.md 'TechnicalAnalysis\.Candles\.CandleInNeck\<T\>') indicator\. |
| [GetLookback\(\)](CandleInNeck_T_.GetLookback().md 'TechnicalAnalysis\.Candles\.CandleInNeck\<T\>\.GetLookback\(\)') | Returns the lookback period for the indicator\. |
| [GetPatternRecognition\(int\)](CandleInNeck_T_.GetPatternRecognition(int).md 'TechnicalAnalysis\.Candles\.CandleInNeck\<T\>\.GetPatternRecognition\(int\)') | Checks if the pattern is recognized at a specific index\. |
