/* Given three numbers, write a method that adds two first ones and multiplies them by a third one.
Expected input and output:
AddAndMultiply(2, 4, 5) → 30 */


using System;

namespace _1._Basics___Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int Result;

            Console.WriteLine("This program takes 3 numbers. It adds the first 2 and multiplies the result to the third number.");
            Console.WriteLine("Please enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            Result = AddAndMultiply(a, b, c);
            Console.WriteLine(string.Format("\nThe answer is {0}", Result));
        }

        static int AddAndMultiply (int a, int b, int c)
        {
            int Result;

            Result = (a + b) * c;
            return Result;
        }
    }

    
}
