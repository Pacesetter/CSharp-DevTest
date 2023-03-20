using ConsoleApp1;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            using StreamReader pressureAsStringStreamReader = new(@"..\..\..\Pressure_As_ADC_Data_Strings.txt");
            using StreamWriter PressureAsVoltageStreamWriter = new(@"..\..\..\Pressure_As_Voltages.txt", true);
            string line;

            while ((line = pressureAsStringStreamReader.ReadLine()) != null)
            {
                // Implement specification.
            }
        }
        catch (IOException ioException)
        {
            Console.WriteLine($"IOException: {ioException.Message}");
            throw;
        }
    }
}
