/* Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
Expected input and output
IfConsistsOfUppercaseLetters("xyz") → false
IfConsistsOfUppercaseLetters("DOG") → true
IfConsistsOfUppercaseLetters("L9#") → false */

using System;

namespace PlayArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            bool isAllCaps;

            Console.WriteLine("This program checks if the string you enter consists of only uppercase letters.");
            Console.Write("Enter a string (3 Characters only): ");
            UserInput = Console.ReadLine();

            isAllCaps = IfConsistsOfUppercaseLetters(UserInput);
            Console.WriteLine("--> {0}", isAllCaps);

            return;
        }

        static bool IfConsistsOfUppercaseLetters (string UserInput)
        {
            bool UpperAllCheck = true;

            foreach (char c in UserInput)
            {
                UpperAllCheck = Char.IsUpper(c);

                if (UpperAllCheck == false)
                {
                    break;
                }
            }

            return UpperAllCheck;
        }

        
    }
}
