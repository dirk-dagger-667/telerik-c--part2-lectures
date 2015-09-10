using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the most frequent number in an array. Example:
    //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


namespace MostCommonElement
{
    class MostCommon
    {
        static void Main(string[] args)
        {

            string arrayString = Console.ReadLine();
            char[] delimiter = new char[] {' '};
            string[] realArray = arrayString.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
            int[] arrayOfNumbers = new int[realArray.Length];

            for (int i = 0; i < realArray.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(realArray[i]);
            }

            Array.Sort(arrayOfNumbers);
            int counter = 0;
            int position = 0;
            int bestLength = 0;
            int bestPosition = 0;
            for (int k = 0; k < arrayOfNumbers.Length; k++)
            {
                if (k == arrayOfNumbers.Length - 1)
                {
                    break;
                }
                if (arrayOfNumbers[k] == arrayOfNumbers[k + 1])
                {
                    position = k - 1;
                    counter++;
                    if (bestLength < counter)
                    {
                        bestPosition = position;
                        bestLength = counter;
                    }

                }
                else
                {
                    counter = 1;
                }

            }
            Console.WriteLine(arrayOfNumbers[bestPosition] + " " + bestLength + " times");

        }
    }
}
