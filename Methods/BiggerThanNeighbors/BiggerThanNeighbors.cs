using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).


namespace BiggerThanNeighbors
{
    class BiggerThanNeighbors
    {
        static bool CheckingNieghbors(int position, int[] array)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }

            else
            {
                return false;
            }
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
            Console.WriteLine("Enter the position of the desired element(bigger than 0 and smaller than the last element) : ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine(@"Enter the array using "","" and ""  "" between each element : ");
            string inputArray = Console.ReadLine();

            Console.WriteLine(CheckingNieghbors(position, StringToIntArray(inputArray)));
        }
    }
}
