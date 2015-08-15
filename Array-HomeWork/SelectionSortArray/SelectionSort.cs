using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortArray
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements : ");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arrayForSorting = new int[numberOfElements];

            for (int i = 0; i < arrayForSorting.Length; i++)
            {
                Console.WriteLine("Enter the {0} element of the array : ", i);
                arrayForSorting[i] = int.Parse(Console.ReadLine());
            }

            int indexOfSmallestNumber = 0;
            int memoryOfSmallestNumber = 0;
            for (int i = 0; i < arrayForSorting.Length; i++)
            {
                indexOfSmallestNumber = i;
                for (int j = i + 1; j < arrayForSorting.Length; j++)
                {
                    if (arrayForSorting[j] < arrayForSorting[indexOfSmallestNumber])
                    {
                        indexOfSmallestNumber = j;
                    }
                }
                memoryOfSmallestNumber = arrayForSorting[i];
                arrayForSorting[i] = arrayForSorting[indexOfSmallestNumber];
                arrayForSorting[indexOfSmallestNumber] = memoryOfSmallestNumber;
            }
            for (int i = 0; i < arrayForSorting.Length - 1; i++)
            {
                Console.Write(arrayForSorting[i] + " ");
            }
            Console.Write(arrayForSorting[arrayForSorting.Length - 1]);
        }
    }
}
