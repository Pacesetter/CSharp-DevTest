namespace ConsoleApp1
{
    internal class FilePaths
    {
        internal static string PressureVoltagesFilePath
        {
            get
            {
                return @"..\..\..\Pressure Data\Pressure_As_Voltages.txt";
            }
        }

        internal static string PressureDataStringsFilePath
        {
            get
            {
                return @"..\..\..\Pressure Data\Pressure_As_ADC_Data_Strings.txt";
            }
        }

        internal static string PressureValuesFilePath
        {
            get
            {
                return @"..\..\..\Pressure Data\Pressure_As_kPa.txt";
            }
        }
    }
}
