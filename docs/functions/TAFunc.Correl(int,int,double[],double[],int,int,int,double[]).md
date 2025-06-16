#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions').[TAFunc](TAFunc.md 'TechnicalAnalysis\.Functions\.TAFunc')

## TAFunc\.Correl\(int, int, double\[\], double\[\], int, int, int, double\[\]\) Method

Calculates the Pearson Correlation Coefficient \- a measure of linear correlation between two variables\.

```csharp
public static TechnicalAnalysis.Common.RetCode Correl(int startIdx, int endIdx, in double[] inReal0, in double[] inReal1, in int optInTimePeriod, ref int outBegIdx, ref int outNBElement, ref double[] outReal);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation within the input arrays\.

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation within the input arrays\.

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).inReal0'></a>

`inReal0` [System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

Input array of first variable values \(e\.g\., first security's prices\)\.

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).inReal1'></a>

`inReal1` [System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

Input array of second variable values \(e\.g\., second security's prices\)\.

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).optInTimePeriod'></a>

`optInTimePeriod` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

Number of periods for the correlation calculation\. Typical value: 20\.

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).outBegIdx'></a>

`outBegIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The index of the first valid output value\.

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).outNBElement'></a>

`outNBElement` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The number of valid output elements\.

<a name='TechnicalAnalysis.Functions.TAFunc.Correl(int,int,double[],double[],int,int,int,double[]).outReal'></a>

`outReal` [System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

Output array for the correlation coefficient values\.

#### Returns
[TechnicalAnalysis\.Common\.RetCode](https://docs.microsoft.com/en-us/dotnet/api/TechnicalAnalysis.Common.RetCode 'TechnicalAnalysis\.Common\.RetCode')  
A RetCode indicating the success or failure of the calculation\.

### Remarks
Correlation measures the strength and direction of the linear relationship between two variables\.

Values range from \-1 to \+1:
\- \+1: Perfect positive correlation \(variables move together\)
\- 0: No linear correlation
\- \-1: Perfect negative correlation \(variables move inversely\)

Interpretation:
\- 0\.8 to 1\.0: Very strong positive correlation
\- 0\.6 to 0\.8: Strong positive correlation
\- 0\.4 to 0\.6: Moderate positive correlation
\- 0\.2 to 0\.4: Weak positive correlation
\- \-0\.2 to 0\.2: No or negligible correlation
\- \-0\.4 to \-0\.2: Weak negative correlation
\- \-0\.6 to \-0\.4: Moderate negative correlation
\- \-0\.8 to \-0\.6: Strong negative correlation
\- \-1\.0 to \-0\.8: Very strong negative correlation

Uses in trading:
\- Pairs trading: Finding highly correlated securities
\- Portfolio diversification: Selecting uncorrelated assets
\- Risk management: Understanding market relationships
\- Intermarket analysis: Studying cross\-asset relationships

Note: Correlation does not imply causation\.