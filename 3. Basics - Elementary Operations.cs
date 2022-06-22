/* Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division.Remember that you can't divide any number by 0!
Expected input and output
ElementaryOperations(3, 8) → 11, -5, 24, 0.375 */


using System;

namespace _1._Basics___Elementary_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string Results;

            Console.WriteLine("This program returns the results of two numbers in arithmetic operations.");
            Console.WriteLine("Please enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Results = ElementaryOperations(a, b);
            Console.WriteLine(Results);
            Console.ReadKey();
        }

        static string ElementaryOperations(double Num1, double Num2)
        {
            string ResultString;
            string Sum;
            string Diff;
            string Prod;
            string Quo;

            Sum = Convert.ToString(Num1 + Num2);
            Diff = Convert.ToString(Num1 - Num2);
            Prod = Convert.ToString(Num1 * Num2);

            if (Num2 == 0)
            {
                Quo = "Cannot divide a number by 0.";
            }
            else
            {
                Quo = Convert.ToString(Num1 / Num2);
            }
            
            ResultString = Sum +"\t" + Diff + "\t" + Prod  + "\t" + Quo;
            return ResultString;
        }
    }
}
