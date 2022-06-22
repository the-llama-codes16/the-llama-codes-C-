/* Given an integer, write a method that returns its absolute value.
Expected input and output
AbsoluteValue(6832) → 6832
AbsoluteValue(-392) → 392 */

using System;

namespace PlayArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput;

            Console.WriteLine("This Program returns the absolute value of the number you enter.");
            Console.Write("Enter number: ");
            UserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + AbsoluteValue(UserInput));

            return;
        }

        static int AbsoluteValue (int UserInput)
        {
            if (UserInput >= 0)
            {
                return UserInput; 
            }
            else
            {
                return (-UserInput);
            }

        }
    }
}
