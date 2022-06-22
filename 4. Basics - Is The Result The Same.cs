/* Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.
Expected input and output
IsResultTheSame(2+2, 2*2) → true
IsResultTheSame(9/3, 16-1) → false */


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
            int Num4;
            string OperA;
            string OperB;
            bool Result;

            Console.WriteLine("This program accepts 4 numbers and 2 arithmetic operations and tests if the results are the same.");
            Console.WriteLine("Example: (2 + 2, 2 * 2)");
            Console.WriteLine("Please write the corresponding keyword for each operation:");
            Console.WriteLine("a -> Addition\ns -> Subtraction\nm -> Multiplication\nd -> Division");
            Console.WriteLine("\nFIRST PAIR\nEnter first operation: ");
            OperA = Console.ReadLine();
            OperA.ToLower();
           
            Console.WriteLine("Please enter 1st number for 1st pair: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number for 1st pair: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSECOND PAIR\nEnter second operation: ");
            OperB = Console.ReadLine();
            OperB.ToLower();

            Console.WriteLine("Please enter 1st number for 2nd pair: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number for 2nd pair: ");
            Num4 = Convert.ToInt32(Console.ReadLine());

            Result = IsResultTheSame(Num1, Num2, Num3, Num4, OperA, OperB);

            Console.WriteLine("\n" + Result);

            return ;
        }

        static bool IsResultTheSame(int Num1, int Num2, int Num3, int Num4, string OperA, string OperB)
        {
            int ResultA = 0;
            int ResultB = 0;
            bool CompareRes;

            switch (OperA)
            {
                case "a":
                    ResultA = Num1 + Num2;
                    break;
                case "s":
                    ResultA = Num1 - Num2;
                    break;
                case "m":
                    ResultA = Num1 * Num2;
                    break;
                case "d":
                    if (Num2 == 0) 
                    {
                        Console.WriteLine("\n2nd Number cannot be 0 if operation is division. Please try again.");
                        Environment.Exit(13);
                    }
                    else
                    {
                        ResultA = Num1 / Num2;
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid input for first operation. Please try again.");
                    Environment.Exit(13);
                    break;
            }

            switch (OperB)
            {
                case "a":
                    ResultB = Num3 + Num4;
                    break;
                case "s":
                    ResultB = Num3 - Num4;
                    break;
                case "m":
                    ResultB = Num3 * Num4;
                    break;
                case "d":
                    if (Num4 == 0)
                    {
                        Console.WriteLine("\n2nd Number cannot be 0 if operation is division. Please try again.");
                        Environment.Exit(13);
                    }
                    else
                    {
                        ResultB = Num3 / Num4;
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid input for second operation. Please try again.");
                    Environment.Exit(13);
                    break;
            }

            CompareRes = (ResultA == ResultB ? true : false);

            return CompareRes;
        }
    }
}
