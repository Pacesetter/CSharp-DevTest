# CSharp-DevTest
A short c# coding challenge to access a developer's ability to code to a provided specification.

## What You're Trying To Do
The task is to write a clean, easy-to-read console application. This console application should convert each pressure data string in `Pressure_As_ADC_Data_Strings.txt` into a voltage, then into kPa using the information, data structure breakdown and formulas found below.

* `Pressure_As_ADC_Data_Strings.txt` contains the pressure data strings.
* `Pressure_As_Voltages.txt` is where the voltages are to be written to, at the precision of 5 decimal places. One value per line.
* `Pressure_As_kPa.txt` is where the final pressure values in kPa are to be written to, at the precision of 2 decimal places. One value per line.

### Pressure ADC Data Strings To Integer Conversion
The following is how the string input is converted to a pressure voltage for use:

String input is 7 characters:  \<SEQUENCE NUMBER\>\<20 BIT PRESSURE DATA AS 5 CHARACTERS\>\<CR\>
So, if the string value is 0FFFF, and the Sequence Number is 0, the output is 00FFFFCR
So, data range is:
X00000CR – XFFFFFCR
Where X is the Sequence Number in the range {0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F}
When converting the HEX pressure reading to a voltage, remove the Sequence Number from the pressure string input before converting it to an integer.

### Pressure Integer Data To Voltage Conversion Formula
Once converted to an integer, conversion to a voltage uses the following formula:
```
PressureAsVoltage = (PressureAsInt \* (RawHighVoltage - RawLowVoltage) / ScaleHighAsInt) - VoltageOffset
Formula values being:
RawLowVoltage = 0.0 V
RawHighVoltage = 5.0 V
ScaleHighAsInt = 1048575
VoltageOffset = 0.0 V
1048575 is the highest possible value in decimal form from the pressure string readings. 
(HEX FFFFF = 1048575)
```

### Pressure Raw Voltage to Pressure (kPa) Reading Formula
```
Pressure = ((RawVoltage - RawLowVoltage) / (RawHighVoltage - RawLowVoltage)) \* (ScaleHigh - ScaleLow)
Formula values being:
RawLowVoltage = 0.0 V
RawHighVoltage = 5.0 V
ScaleLow = 0.0 kPa
ScaleHigh = 68947.573 kPa
```

## What You're Going To Need
1. A git client
2. An IDE.
   * [Visual Studio 2022](https://visualstudio.microsoft.com/vs/community/).
3. [.NET 7](https://dotnet.microsoft.com/en-us/download)

## How To Get Started
1. Clone this repository to your computer (https://github.com/Pacesetter/CSharp-DevTest.git)
2. Open the project in Visual Studio 2022
3. This should kick off a `dotnet restore` automatically, but if not manually run that in a command prompt
4. Use Pressure_As_ADC_Data_Strings.txt and the above instructions as a starting point.
5. When you're done, submit your code by zipping up your entire solution, and email it to me.
