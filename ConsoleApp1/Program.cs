namespace ConsoleApp1;

class Program
{
    static void Main(String[] args)
    {
        double myTemp = 24.5;
        double myTempFahrenheit = ConvertCToF(myTemp);
        double checkOurWork = ConvertFToC(myTempFahrenheit);

        Console.WriteLine(myTemp);
        Console.WriteLine(myTempFahrenheit);
        Console.WriteLine(checkOurWork);
    }

    static double ConvertCToF(double celsius)
    {
        return celsius * (9.0 / 5.0) + 32;
    }

    static double ConvertFToC(double fahrenheit)
    {
        return (fahrenheit - 32) * (5.0 / 9.0);
    }

}