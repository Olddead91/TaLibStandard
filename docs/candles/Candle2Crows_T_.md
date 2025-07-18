#### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md 'Atypical\.TechnicalAnalysis\.Candles')
### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md#TechnicalAnalysis.Candles 'TechnicalAnalysis\.Candles')

## Candle2Crows\<T\> Class

Two Crows \(Pattern Recognition\)

```csharp
public class Candle2Crows<T> : TechnicalAnalysis.Common.CandleIndicator<T>
    where T : System.Numerics.IFloatingPoint<T>
```
#### Type parameters

<a name='TechnicalAnalysis.Candles.Candle2Crows_T_.T'></a>

`T`

The type of the array elements\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.CandleIndicator&lt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1')[T](Candle2Crows_T_.md#TechnicalAnalysis.Candles.Candle2Crows_T_.T 'TechnicalAnalysis\.Candles\.Candle2Crows\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1') &#129106; Candle2Crows\<T\>

| Constructors | |
| :--- | :--- |
| [Candle2Crows\(T\[\], T\[\], T\[\], T\[\]\)](Candle2Crows_T_.Candle2Crows(T[],T[],T[],T[]).md 'TechnicalAnalysis\.Candles\.Candle2Crows\<T\>\.Candle2Crows\(T\[\], T\[\], T\[\], T\[\]\)') | Two Crows \(Pattern Recognition\) |

| Methods | |
| :--- | :--- |
| [Compute\(int, int\)](Candle2Crows_T_.Compute(int,int).md 'TechnicalAnalysis\.Candles\.Candle2Crows\<T\>\.Compute\(int, int\)') | Computes the [Candle2Crows&lt;T&gt;](Candle2Crows_T_.md 'TechnicalAnalysis\.Candles\.Candle2Crows\<T\>') indicator\. |
| [GetLookback\(\)](Candle2Crows_T_.GetLookback().md 'TechnicalAnalysis\.Candles\.Candle2Crows\<T\>\.GetLookback\(\)') | Returns the lookback period for the indicator\. |
| [GetPatternRecognition\(int\)](Candle2Crows_T_.GetPatternRecognition(int).md 'TechnicalAnalysis\.Candles\.Candle2Crows\<T\>\.GetPatternRecognition\(int\)') | Checks if the pattern is recognized at a specific index\. |
