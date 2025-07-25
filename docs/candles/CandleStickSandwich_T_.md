#### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md 'Atypical\.TechnicalAnalysis\.Candles')
### [TechnicalAnalysis\.Candles](Atypical.TechnicalAnalysis.Candles.md#TechnicalAnalysis.Candles 'TechnicalAnalysis\.Candles')

## CandleStickSandwich\<T\> Class

Stick Sandwich \(Pattern Recognition\)

```csharp
public class CandleStickSandwich<T> : TechnicalAnalysis.Common.CandleIndicator<T>
    where T : System.Numerics.IFloatingPoint<T>
```
#### Type parameters

<a name='TechnicalAnalysis.Candles.CandleStickSandwich_T_.T'></a>

`T`

The type of the array elements\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; [TechnicalAnalysis\.Common\.CandleIndicator&lt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1')[T](CandleStickSandwich_T_.md#TechnicalAnalysis.Candles.CandleStickSandwich_T_.T 'TechnicalAnalysis\.Candles\.CandleStickSandwich\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.CandleIndicator-1 'TechnicalAnalysis\.Common\.CandleIndicator\`1') &#129106; CandleStickSandwich\<T\>

| Constructors | |
| :--- | :--- |
| [CandleStickSandwich\(T\[\], T\[\], T\[\], T\[\]\)](CandleStickSandwich_T_.CandleStickSandwich(T[],T[],T[],T[]).md 'TechnicalAnalysis\.Candles\.CandleStickSandwich\<T\>\.CandleStickSandwich\(T\[\], T\[\], T\[\], T\[\]\)') | Stick Sandwich \(Pattern Recognition\) |

| Methods | |
| :--- | :--- |
| [Compute\(int, int\)](CandleStickSandwich_T_.Compute(int,int).md 'TechnicalAnalysis\.Candles\.CandleStickSandwich\<T\>\.Compute\(int, int\)') | Computes the [CandleStickSandwich&lt;T&gt;](CandleStickSandwich_T_.md 'TechnicalAnalysis\.Candles\.CandleStickSandwich\<T\>') indicator\. |
| [GetLookback\(\)](CandleStickSandwich_T_.GetLookback().md 'TechnicalAnalysis\.Candles\.CandleStickSandwich\<T\>\.GetLookback\(\)') | Returns the lookback period for the indicator\. |
| [GetPatternRecognition\(int\)](CandleStickSandwich_T_.GetPatternRecognition(int).md 'TechnicalAnalysis\.Candles\.CandleStickSandwich\<T\>\.GetPatternRecognition\(int\)') | Checks if the pattern is recognized at a specific index\. |
