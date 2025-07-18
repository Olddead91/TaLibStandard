#### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md 'Atypical\.TechnicalAnalysis\.Candles')
### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md#TechnicalAnalysis.Candles 'TechnicalAnalysis\.Candles')

## CandleLongLeggedDoji\<T\> Class

Long Legged Doji \(Pattern Recognition\)

```csharp
public class CandleLongLeggedDoji<T> : TechnicalAnalysis.Common.CandleIndicator<T>
    where T : System.Numerics.IFloatingPoint<T>
```
#### Type parameters

<a name='TechnicalAnalysis.Candles.CandleLongLeggedDoji_T_.T'></a>

`T`

The type of the array elements\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.CandleIndicator&lt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1')[T](CandleLongLeggedDoji_T_.md#TechnicalAnalysis.Candles.CandleLongLeggedDoji_T_.T 'TechnicalAnalysis\.Candles\.CandleLongLeggedDoji\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1') &#129106; CandleLongLeggedDoji\<T\>

| Constructors | |
| :--- | :--- |
| [CandleLongLeggedDoji\(T\[\], T\[\], T\[\], T\[\]\)](CandleLongLeggedDoji_T_.CandleLongLeggedDoji(T[],T[],T[],T[]).md 'TechnicalAnalysis\.Candles\.CandleLongLeggedDoji\<T\>\.CandleLongLeggedDoji\(T\[\], T\[\], T\[\], T\[\]\)') | Long Legged Doji \(Pattern Recognition\) |

| Methods | |
| :--- | :--- |
| [Compute\(int, int\)](CandleLongLeggedDoji_T_.Compute(int,int).md 'TechnicalAnalysis\.Candles\.CandleLongLeggedDoji\<T\>\.Compute\(int, int\)') | Computes the [CandleLongLeggedDoji&lt;T&gt;](CandleLongLeggedDoji_T_.md 'TechnicalAnalysis\.Candles\.CandleLongLeggedDoji\<T\>') indicator\. |
| [GetLookback\(\)](CandleLongLeggedDoji_T_.GetLookback().md 'TechnicalAnalysis\.Candles\.CandleLongLeggedDoji\<T\>\.GetLookback\(\)') | Returns the lookback period for the indicator\. |
| [GetPatternRecognition\(int\)](CandleLongLeggedDoji_T_.GetPatternRecognition(int).md 'TechnicalAnalysis\.Candles\.CandleLongLeggedDoji\<T\>\.GetPatternRecognition\(int\)') | Checks if the pattern is recognized at a specific index\. |
