/* Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
Expected input and output
IfGreaterThanThirdOne([2, 7, 12]) → true
IfGreaterThanThirdOne([-5, -8, 50]) → false */

using System;

namespace PlayArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UserInput = new int[3];
            bool Result;

            //Collect input from user
            Console.WriteLine("This program checks if the product or sum of the first 2 numbers is greater than the third one.");
            Console.WriteLine("Please enter 3 numbers:");
            
            for (int ctr = 0; ctr < 3; ctr++)
            {
                Console.Write("{0}:", ctr + 1);
                UserInput[ctr] = Convert.ToInt32(Console.ReadLine());
            }

            //Call the method 
            Result = IfGreaterThanThirdOne(UserInput);

            Console.WriteLine("--> {0}", Result);

            return;
        }


        static bool IfGreaterThanThirdOne(int[] UserInput)
        {
            bool Result;

            if (UserInput[0] + UserInput[1] > UserInput[2] || UserInput[0] * UserInput[1] > UserInput[2])
            {
                Result = true;
            }
            else
            {
                Result = false;
            }

            return Result;
        }
    }
}
