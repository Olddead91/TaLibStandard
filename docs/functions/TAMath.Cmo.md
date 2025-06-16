#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions').[TAMath](TAMath.md 'TechnicalAnalysis\.Functions\.TAMath')

## TAMath\.Cmo Method

| Overloads | |
| :--- | :--- |
| [Cmo\(int, int, double\[\], int\)](TAMath.Cmo.md#TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[],int) 'TechnicalAnalysis\.Functions\.TAMath\.Cmo\(int, int, double\[\], int\)') | Calculates the Chande Momentum Oscillator \(CMO\) which measures momentum on both up and down days\. |
| [Cmo\(int, int, double\[\]\)](TAMath.Cmo.md#TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[]) 'TechnicalAnalysis\.Functions\.TAMath\.Cmo\(int, int, double\[\]\)') | Calculates the Chande Momentum Oscillator \(CMO\) using the default time period of 14\. |
| [Cmo\(int, int, float\[\], int\)](TAMath.Cmo.md#TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[],int) 'TechnicalAnalysis\.Functions\.TAMath\.Cmo\(int, int, float\[\], int\)') | Calculates the Chande Momentum Oscillator \(CMO\) which measures momentum on both up and down days\. |
| [Cmo\(int, int, float\[\]\)](TAMath.Cmo.md#TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[]) 'TechnicalAnalysis\.Functions\.TAMath\.Cmo\(int, int, float\[\]\)') | Calculates the Chande Momentum Oscillator \(CMO\) using the default time period of 14\. |

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[],int)'></a>

## TAMath\.Cmo\(int, int, double\[\], int\) Method

Calculates the Chande Momentum Oscillator \(CMO\) which measures momentum on both up and down days\.

```csharp
public static TechnicalAnalysis.Functions.CmoResult Cmo(int startIdx, int endIdx, double[] real, int timePeriod);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[],int).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[],int).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[],int).real'></a>

`real` [System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

Array of input values \(usually closing prices\)\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[],int).timePeriod'></a>

`timePeriod` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The number of periods to use in the calculation \(default: 14\)\.

#### Returns
[CmoResult](CmoResult.md 'TechnicalAnalysis\.Functions\.CmoResult')  
A CmoResult containing the calculated values and metadata\.

### Remarks
The CMO is calculated as: \(\(Sum of up days \- Sum of down days\) / \(Sum of up days \+ Sum of down days\)\) \* 100\.
It oscillates between \-100 and \+100, with values above \+50 indicating overbought conditions
and values below \-50 indicating oversold conditions\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[])'></a>

## TAMath\.Cmo\(int, int, double\[\]\) Method

Calculates the Chande Momentum Oscillator \(CMO\) using the default time period of 14\.

```csharp
public static TechnicalAnalysis.Functions.CmoResult Cmo(int startIdx, int endIdx, double[] real);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[]).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[]).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,double[]).real'></a>

`real` [System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

Array of input values \(usually closing prices\)\.

#### Returns
[CmoResult](CmoResult.md 'TechnicalAnalysis\.Functions\.CmoResult')  
A CmoResult containing the calculated values and metadata\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[],int)'></a>

## TAMath\.Cmo\(int, int, float\[\], int\) Method

Calculates the Chande Momentum Oscillator \(CMO\) which measures momentum on both up and down days\.

```csharp
public static TechnicalAnalysis.Functions.CmoResult Cmo(int startIdx, int endIdx, float[] real, int timePeriod);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[],int).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[],int).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[],int).real'></a>

`real` [System\.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System\.Single')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

Array of input values \(usually closing prices\)\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[],int).timePeriod'></a>

`timePeriod` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The number of periods to use in the calculation\.

#### Returns
[CmoResult](CmoResult.md 'TechnicalAnalysis\.Functions\.CmoResult')  
A CmoResult containing the calculated values and metadata\.

### Remarks
This overload accepts float arrays and converts them to double arrays for calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[])'></a>

## TAMath\.Cmo\(int, int, float\[\]\) Method

Calculates the Chande Momentum Oscillator \(CMO\) using the default time period of 14\.

```csharp
public static TechnicalAnalysis.Functions.CmoResult Cmo(int startIdx, int endIdx, float[] real);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[]).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[]).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation range\.

<a name='TechnicalAnalysis.Functions.TAMath.Cmo(int,int,float[]).real'></a>

`real` [System\.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System\.Single')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

Array of input values \(usually closing prices\)\.

#### Returns
[CmoResult](CmoResult.md 'TechnicalAnalysis\.Functions\.CmoResult')  
A CmoResult containing the calculated values and metadata\.

### Remarks
This overload accepts float arrays and converts them to double arrays for calculation\.