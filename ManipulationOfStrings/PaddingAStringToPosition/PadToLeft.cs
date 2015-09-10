using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

namespace PaddingAStringToPosition
{
    class PadToLeft
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string that's 20 characters long or less : ");
            string stringToPad = Console.ReadLine();

            if (stringToPad.Length < 20)
            {
                Console.WriteLine(stringToPad.PadRight(20,'*'));
            }

            if (stringToPad.Length > 20)
            {
                Console.WriteLine("Write 20 chars OR less!!!!");
                return;
            }
            else
            {
                Console.WriteLine(stringToPad);
            }


        }
    }
}
