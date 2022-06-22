/* Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum.
Expected input and output
DivisibleBy2Or3(15, 30) → 450
DivisibleBy2Or3(2, 90) → 180
DivisibleBy2Or3(7, 12) → 19 */

using System;

namespace PlayArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNum;
            int sNum;
            int Result;

            Console.WriteLine("This program accepts 2 numbers and returns a result.");
            Console.WriteLine("If the two numbers are divisible by 2 or 3: Product");
            Console.WriteLine("If not: Sum");
            Console.Write("Enter the numbers:\na: ");
            fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            sNum = Convert.ToInt32(Console.ReadLine());

            Result = DivisibleBy2or3(fNum, sNum);

            Console.WriteLine("Result -> " + Result);

            return;
        }

        static int DivisibleBy2or3 (int fNum, int sNum)
        {
            int counter = 0;

            if (fNum % 2 == 0 || fNum % 3 == 0)
            {
                counter++;
            }
            if (sNum % 2 == 0 || sNum % 3 == 0)
            {
                counter++;
            }

            if (counter < 2)
            {
                return (fNum + sNum);
            }
            else
            {
                return (fNum * sNum);
            }
        }

        
    }
}
