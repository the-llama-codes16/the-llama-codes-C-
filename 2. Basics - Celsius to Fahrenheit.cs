/* Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) does not exist!
Expected input and output
CtoF(0) → "T = 32F"
CtoF(100) → "T = 212F"
CtoF(-300) → "Temperature below absolute zero!" */


using System;
namespace _1._Basics___Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius;
            double Fahrenheit;

            Console.WriteLine("This program converts temperatures from Celsius to Fahrenheit.");
            Console.WriteLine("Please enter temperature in Celsius: ");
            Celsius = Convert.ToDouble(Console.ReadLine());

            if (Celsius < -271.15)
            {
                Console.WriteLine("Temperature lesser than -271.15°C does not exist. Please try again.");
                Environment.Exit(1);
            }

            Fahrenheit = CtoF(Celsius);

            Console.WriteLine("{0}°C is equivalent to {1}°F.", Celsius, Fahrenheit);
        }

        static double CtoF(double Celsius)
        {
            double Fah;

            Fah = (Celsius * 9 / 5) + 32;

            return Fah;
        }//CtoF
    }
}
