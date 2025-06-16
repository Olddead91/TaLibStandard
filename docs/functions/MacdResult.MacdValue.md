#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions').[MacdResult](MacdResult.md 'TechnicalAnalysis\.Functions\.MacdResult')

## MacdResult\.MacdValue Property

Gets the array of MACD line values\.

```csharp
public double[] MacdValue { get; }
```

#### Property Value
[System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')  
An array of double values representing the MACD line, calculated as the difference
between the fast EMA \(typically 12 periods\) and the slow EMA \(typically 26 periods\)\.