/* Given a number, write a method that returns its cube.
Expected input and output
TheCubeOf(2) → 8
TheCubeOf(-5.5) → -166.375 */

using System;

namespace The_Cube_Of
{
    class Program
    {
        static void Main(string[] args)
        {
            double UserInput;
            double Result;

            Console.WriteLine("This program returns the cube of a number you enter.");
            Console.Write("Enter a number: ");
            UserInput = Convert.ToDouble(Console.ReadLine());

            Result = CalCube(UserInput);

            Console.WriteLine(Result);

            return;
        }

        static double CalCube(double UserInput)
        {
            return (Math.Pow(UserInput,3));
        }


    }


}
