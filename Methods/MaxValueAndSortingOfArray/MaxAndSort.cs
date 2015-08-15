using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueAndSortingOfArray
{
    class MaxAndSort
    {
        static int SearchForMaxElement(int index ,int[] arrayForAnalysis)
        {
            int bestPosition = index;

            for (int i = index; i < arrayForAnalysis.Length; i++)
            {
                if (arrayForAnalysis[bestPosition] < arrayForAnalysis[i])
                {
                    bestPosition = i;
                }
            }

            return bestPosition;
        }

        static int[] SortingArrays(int[] arrayForAnalysis)
        {
            int memoryOfPostion = 0;
            int memoryOfMaxElementPosition = 0;

            for (int i = 0; i < arrayForAnalysis.Length; i++)
            {
                memoryOfPostion = arrayForAnalysis[i];
                memoryOfMaxElementPosition = SearchForMaxElement(i,arrayForAnalysis);
                arrayForAnalysis[i] = arrayForAnalysis[memoryOfMaxElementPosition];
                arrayForAnalysis[memoryOfMaxElementPosition] = memoryOfPostion;
            }

            return arrayForAnalysis;
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
            Console.WriteLine("Enter the starting index of the search : ");
            int startingIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(@"Enter the array using "","" and "" """);
            string inputArray = Console.ReadLine();

            int[] intArray = StringToIntArray(inputArray);

            Console.WriteLine(SearchForMaxElement(startingIndex,intArray));

            int[] sortedArray = SortingArrays(intArray);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
        }
    }
}
