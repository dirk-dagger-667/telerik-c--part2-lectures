using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstElementBiggerThanNeighbors
{
    class FirstElBiggerNeighbors
    {
        static int CheckingNieghbors(int[] array)
        {
            int index = -1;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        static int[] StringToIntArray(string inputArray)
        {
            char[] delimiter = new char[] { ' ', ',' };
            string[] inputOne = inputArray.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            int[] realArray = new int[inputOne.Length];

            for (int i = 0; i < inputOne.Length; i++)
            {
                realArray[i] = int.Parse(inputOne[i]);
            }

            return realArray;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter the array using "","" and ""  "" between each element : ");
            string inputArray = Console.ReadLine();

            Console.WriteLine(CheckingNieghbors(StringToIntArray(inputArray)));
        }
    }
}
