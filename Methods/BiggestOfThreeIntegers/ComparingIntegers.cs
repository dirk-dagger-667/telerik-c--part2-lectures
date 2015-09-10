using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


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
