using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThreeIntegers
{
    class ComparingIntegers
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber<secondNumber)
            {
                return secondNumber;
            }

            else
            {
                return firstNumber;
            }
        }
        
        static void Main(string[] args)
        {
            int firstInterger = int.Parse(Console.ReadLine());
            int secondInterger = int.Parse(Console.ReadLine());
            int thirdInterger = int.Parse(Console.ReadLine());

            if (GetMax(firstInterger, secondInterger) < GetMax(secondInterger, thirdInterger))
            {
                Console.WriteLine(GetMax(secondInterger, thirdInterger));
            }

            else
            {
                Console.WriteLine(GetMax(firstInterger, secondInterger));
            }
        }
    }
}
