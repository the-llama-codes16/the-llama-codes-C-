/* Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
Expected input and output
ModuloOperations(8, 5, 2) → 1 */


using System;

namespace PlayArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Num3;
            int Result;

            Console.WriteLine("This program accepts 3 integers and returns the 1st number divided modulo by the 2nd, then the result divided modulo by the 3rd.");
            Console.WriteLine("Example: 8, 5, 2 = 8 % 5 = 3 % 2 = 1\n");

            Console.Write("Please enter the 1st Number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the 2nd Number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the 3rd Number: ");
            Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 == 0 || Num2 == 0 || Num3 == 0)
            {
                Console.WriteLine("ERROR: You cannot divide a number by 0. Please try again.");
                Environment.Exit(13);
            }

            Result = ModuloOperations(Num1, Num2, Num3);
            Console.WriteLine("Result = " + Result);
        }

        static int ModuloOperations(int Num1, int Num2, int Num3)
        {
            int ModAns;

            

            ModAns = Num1 % Num2;
            ModAns %= Num3;

            return ModAns;
        }
    }
}
