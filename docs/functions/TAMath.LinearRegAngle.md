#### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md 'Atypical\.TechnicalAnalysis\.Functions')
### [TechnicalAnalysis\.Functions](Atypical.TechnicalAnalysis.Functions.md#TechnicalAnalysis.Functions 'TechnicalAnalysis\.Functions').[TAMath](TAMath.md 'TechnicalAnalysis\.Functions\.TAMath')

## TAMath\.LinearRegAngle Method

| Overloads | |
| :--- | :--- |
| [LinearRegAngle\(int, int, double\[\], int\)](TAMath.LinearRegAngle.md#TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[],int) 'TechnicalAnalysis\.Functions\.TAMath\.LinearRegAngle\(int, int, double\[\], int\)') | Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator\. |
| [LinearRegAngle\(int, int, double\[\]\)](TAMath.LinearRegAngle.md#TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[]) 'TechnicalAnalysis\.Functions\.TAMath\.LinearRegAngle\(int, int, double\[\]\)') | Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator using the default time period\. |
| [LinearRegAngle\(int, int, float\[\], int\)](TAMath.LinearRegAngle.md#TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[],int) 'TechnicalAnalysis\.Functions\.TAMath\.LinearRegAngle\(int, int, float\[\], int\)') | Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator using float arrays\. |
| [LinearRegAngle\(int, int, float\[\]\)](TAMath.LinearRegAngle.md#TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[]) 'TechnicalAnalysis\.Functions\.TAMath\.LinearRegAngle\(int, int, float\[\]\)') | Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator using float arrays and the default time period\. |

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[],int)'></a>

## TAMath\.LinearRegAngle\(int, int, double\[\], int\) Method

Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator\.

```csharp
public static TechnicalAnalysis.Functions.LinearRegAngleResult LinearRegAngle(int startIdx, int endIdx, double[] real, int timePeriod);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[],int).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[],int).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[],int).real'></a>

`real` [System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

An array of real values \(typically closing prices\)\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[],int).timePeriod'></a>

`timePeriod` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The number of periods for the linear regression \(default: 14\)\.

#### Returns
[LinearRegAngleResult](LinearRegAngleResult.md 'TechnicalAnalysis\.Functions\.LinearRegAngleResult')  
A LinearRegAngleResult object containing the calculated angle values in degrees\.

### Remarks
The Linear Regression Angle indicator calculates the angle of the linear regression line
over the specified period\. The angle is expressed in degrees and represents the slope of the trend\.
Positive angles indicate an uptrend, while negative angles indicate a downtrend\.
The steeper the angle, the stronger the trend\. This indicator can be used to quantify
trend strength and identify potential trend changes when the angle crosses through zero\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[])'></a>

## TAMath\.LinearRegAngle\(int, int, double\[\]\) Method

Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator using the default time period\.

```csharp
public static TechnicalAnalysis.Functions.LinearRegAngleResult LinearRegAngle(int startIdx, int endIdx, double[] real);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[]).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[]).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,double[]).real'></a>

`real` [System\.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System\.Double')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

An array of real values \(typically closing prices\)\.

#### Returns
[LinearRegAngleResult](LinearRegAngleResult.md 'TechnicalAnalysis\.Functions\.LinearRegAngleResult')  
A LinearRegAngleResult object containing the calculated angle values in degrees\.

### Remarks
Uses the default time period of 14\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[],int)'></a>

## TAMath\.LinearRegAngle\(int, int, float\[\], int\) Method

Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator using float arrays\.

```csharp
public static TechnicalAnalysis.Functions.LinearRegAngleResult LinearRegAngle(int startIdx, int endIdx, float[] real, int timePeriod);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[],int).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[],int).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[],int).real'></a>

`real` [System\.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System\.Single')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

An array of real values \(typically closing prices\)\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[],int).timePeriod'></a>

`timePeriod` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The number of periods for the linear regression\.

#### Returns
[LinearRegAngleResult](LinearRegAngleResult.md 'TechnicalAnalysis\.Functions\.LinearRegAngleResult')  
A LinearRegAngleResult object containing the calculated angle values in degrees\.

### Remarks
This overload accepts float arrays and converts them to double arrays before processing\.
This may result in a minor performance overhead due to the conversion process\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[])'></a>

## TAMath\.LinearRegAngle\(int, int, float\[\]\) Method

Calculates the Linear Regression Angle \(LINEARREG\_ANGLE\) indicator using float arrays and the default time period\.

```csharp
public static TechnicalAnalysis.Functions.LinearRegAngleResult LinearRegAngle(int startIdx, int endIdx, float[] real);
```
#### Parameters

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[]).startIdx'></a>

`startIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The starting index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[]).endIdx'></a>

`endIdx` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The ending index for the calculation\.

<a name='TechnicalAnalysis.Functions.TAMath.LinearRegAngle(int,int,float[]).real'></a>

`real` [System\.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System\.Single')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

An array of real values \(typically closing prices\)\.

#### Returns
[LinearRegAngleResult](LinearRegAngleResult.md 'TechnicalAnalysis\.Functions\.LinearRegAngleResult')  
A LinearRegAngleResult object containing the calculated angle values in degrees\.

### Remarks
Uses the default time period of 14\. This overload accepts float arrays and converts them to double arrays\.