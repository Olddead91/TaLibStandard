#### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md 'Atypical\.TechnicalAnalysis\.Candles')
### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md#TechnicalAnalysis.Candles 'TechnicalAnalysis\.Candles')

## CandleHammer\<T\> Class

Hammer \(Pattern Recognition\)

```csharp
public class CandleHammer<T> : TechnicalAnalysis.Common.CandleIndicator<T>
    where T : System.Numerics.IFloatingPoint<T>
```
#### Type parameters

<a name='TechnicalAnalysis.Candles.CandleHammer_T_.T'></a>

`T`

The type of the array elements\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.CandleIndicator&lt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1')[T](CandleHammer_T_.md#TechnicalAnalysis.Candles.CandleHammer_T_.T 'TechnicalAnalysis\.Candles\.CandleHammer\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1') &#129106; CandleHammer\<T\>

| Constructors | |
| :--- | :--- |
| [CandleHammer\(T\[\], T\[\], T\[\], T\[\]\)](CandleHammer_T_.CandleHammer(T[],T[],T[],T[]).md 'TechnicalAnalysis\.Candles\.CandleHammer\<T\>\.CandleHammer\(T\[\], T\[\], T\[\], T\[\]\)') | Hammer \(Pattern Recognition\) |

| Methods | |
| :--- | :--- |
| [Compute\(int, int\)](CandleHammer_T_.Compute(int,int).md 'TechnicalAnalysis\.Candles\.CandleHammer\<T\>\.Compute\(int, int\)') | Computes the [CandleHammer&lt;T&gt;](CandleHammer_T_.md 'TechnicalAnalysis\.Candles\.CandleHammer\<T\>') indicator\. |
| [GetLookback\(\)](CandleHammer_T_.GetLookback().md 'TechnicalAnalysis\.Candles\.CandleHammer\<T\>\.GetLookback\(\)') | Returns the lookback period for the indicator\. |
| [GetPatternRecognition\(int\)](CandleHammer_T_.GetPatternRecognition(int).md 'TechnicalAnalysis\.Candles\.CandleHammer\<T\>\.GetPatternRecognition\(int\)') | Checks if the pattern is recognized at a specific index\. |
