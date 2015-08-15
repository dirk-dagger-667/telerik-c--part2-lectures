using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfANumber
{
    class Number
    {
        static int Counting(int numberOfSearch, int[] arrayForAnalyzing)
        {
            int counter = 0;

            for (int i = 0; i < arrayForAnalyzing.Length; i++)
            {
                if (arrayForAnalyzing[i] == numberOfSearch)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for analyzing : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(@"Enter the sequence using "","" and "" "" ");
            string inputForArray = Console.ReadLine();
            char[] delimiter = new char[] {' ', ','};
            string[] inputOne = inputForArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int[] realArray = new int[inputOne.Length];

            for (int i = 0; i < inputOne.Length; i++)
            {
                realArray[i] = int.Parse(inputOne[i]);
            }

            Console.WriteLine(Counting(number, realArray));

        }
    }
}
