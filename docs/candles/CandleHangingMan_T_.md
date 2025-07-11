#### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md 'Atypical\.TechnicalAnalysis\.Candles')
### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md#TechnicalAnalysis.Candles 'TechnicalAnalysis\.Candles')

## CandleHangingMan\<T\> Class

Hanging Man \(Pattern Recognition\)

```csharp
public class CandleHangingMan<T> : TechnicalAnalysis.Common.CandleIndicator<T>
    where T : System.Numerics.IFloatingPoint<T>
```
#### Type parameters

<a name='TechnicalAnalysis.Candles.CandleHangingMan_T_.T'></a>

`T`

The type of the array elements\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.CandleIndicator&lt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1')[T](CandleHangingMan_T_.md#TechnicalAnalysis.Candles.CandleHangingMan_T_.T 'TechnicalAnalysis\.Candles\.CandleHangingMan\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1') &#129106; CandleHangingMan\<T\>

| Constructors | |
| :--- | :--- |
| [CandleHangingMan\(T\[\], T\[\], T\[\], T\[\]\)](CandleHangingMan_T_.CandleHangingMan(T[],T[],T[],T[]).md 'TechnicalAnalysis\.Candles\.CandleHangingMan\<T\>\.CandleHangingMan\(T\[\], T\[\], T\[\], T\[\]\)') | Hanging Man \(Pattern Recognition\) |

| Methods | |
| :--- | :--- |
| [Compute\(int, int\)](CandleHangingMan_T_.Compute(int,int).md 'TechnicalAnalysis\.Candles\.CandleHangingMan\<T\>\.Compute\(int, int\)') | Computes the [CandleHangingMan&lt;T&gt;](CandleHangingMan_T_.md 'TechnicalAnalysis\.Candles\.CandleHangingMan\<T\>') indicator\. |
| [GetLookback\(\)](CandleHangingMan_T_.GetLookback().md 'TechnicalAnalysis\.Candles\.CandleHangingMan\<T\>\.GetLookback\(\)') | Returns the lookback period for the indicator\. |
| [GetPatternRecognition\(int\)](CandleHangingMan_T_.GetPatternRecognition(int).md 'TechnicalAnalysis\.Candles\.CandleHangingMan\<T\>\.GetPatternRecognition\(int\)') | Checks if the pattern is recognized at a specific index\. |
