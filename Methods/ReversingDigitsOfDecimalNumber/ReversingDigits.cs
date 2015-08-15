using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingDigitsOfDecimalNumber
{
    class ReversingDigits
    {
        static string RevirsingOfDigits(string inputNumber)
        {
            string numberInReverse = null;

            for (int i = inputNumber.Length - 1; i >= 0; i--)
            {
                numberInReverse += inputNumber[i];    
            }

            return numberInReverse;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of which the digits should be reversed : ");
            string inputNumber = Console.ReadLine();

            Console.WriteLine(RevirsingOfDigits(inputNumber));
        }
    }
}
