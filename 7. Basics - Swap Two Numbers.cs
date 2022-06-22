/* Given two integers, write a method that swaps them using temporary variable.
Expected input and output
SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"
SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13" */

using System;

namespace PlayArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNum;
            int sNum;
            
            Console.WriteLine("This program swaps two numbers.");
            Console.WriteLine("Please enter a value for the following:");
            Console.Write("a: ");
            fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            sNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Swapping...");

            SwapTwoNumbers(fNum, sNum);

            return;
        }

        static void SwapTwoNumbers (int fNum, int sNum)
        {
            int Temp;

            Temp = fNum;
            fNum = sNum;
            sNum = Temp;

            Console.WriteLine("a: {0}\nb: {1}", fNum, sNum);

            return;
        }
    }
}
