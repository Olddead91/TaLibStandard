#### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md 'Atypical\.TechnicalAnalysis\.Candles')
### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md#TechnicalAnalysis.Candles 'TechnicalAnalysis\.Candles')

## Candle3LineStrike\<T\> Class

Three\-Line Strike \(Pattern Recognition\)

```csharp
public class Candle3LineStrike<T> : TechnicalAnalysis.Common.CandleIndicator<T>
    where T : System.Numerics.IFloatingPoint<T>
```
#### Type parameters

<a name='TechnicalAnalysis.Candles.Candle3LineStrike_T_.T'></a>

`T`

The type of the array elements\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.CandleIndicator&lt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1')[T](Candle3LineStrike_T_.md#TechnicalAnalysis.Candles.Candle3LineStrike_T_.T 'TechnicalAnalysis\.Candles\.Candle3LineStrike\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1') &#129106; Candle3LineStrike\<T\>

| Constructors | |
| :--- | :--- |
| [Candle3LineStrike\(T\[\], T\[\], T\[\], T\[\]\)](Candle3LineStrike_T_.Candle3LineStrike(T[],T[],T[],T[]).md 'TechnicalAnalysis\.Candles\.Candle3LineStrike\<T\>\.Candle3LineStrike\(T\[\], T\[\], T\[\], T\[\]\)') | Three\-Line Strike \(Pattern Recognition\) |

| Methods | |
| :--- | :--- |
| [Compute\(int, int\)](Candle3LineStrike_T_.Compute(int,int).md 'TechnicalAnalysis\.Candles\.Candle3LineStrike\<T\>\.Compute\(int, int\)') | Computes the [Candle3LineStrike&lt;T&gt;](Candle3LineStrike_T_.md 'TechnicalAnalysis\.Candles\.Candle3LineStrike\<T\>') indicator\. |
| [GetLookback\(\)](Candle3LineStrike_T_.GetLookback().md 'TechnicalAnalysis\.Candles\.Candle3LineStrike\<T\>\.GetLookback\(\)') | Returns the lookback period for the indicator\. |
| [GetPatternRecognition\(int\)](Candle3LineStrike_T_.GetPatternRecognition(int).md 'TechnicalAnalysis\.Candles\.Candle3LineStrike\<T\>\.GetPatternRecognition\(int\)') | Checks if the pattern is recognized at a specific index\. |
