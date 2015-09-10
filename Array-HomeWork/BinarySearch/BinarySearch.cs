using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).


namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            string inputArrayOne = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };

            string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[inputOne.Length];
            for (int i = 0; i < inputOne.Length; i++)
            {
                arr[i] = int.Parse(inputOne[i]);
            }
            Array.Sort(arr);
            int numberToFind = int.Parse(Console.ReadLine());

            BinarySearchInArray(numberToFind, arr);

        }

        static void BinarySearchInArray(int numberToFind, int[] array)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            int currentIndex = startIndex + (endIndex - startIndex) / 2;

            do
            {

                if (array[currentIndex] == numberToFind)
                {
                    Console.WriteLine("{0}", currentIndex);
                    return;
                }
                else if (array[currentIndex] > numberToFind)
                {
                    endIndex = currentIndex;
                    currentIndex = startIndex + (endIndex - startIndex) / 2 - 1;
                }
                else
                {
                    startIndex = currentIndex;
                    currentIndex = startIndex + (endIndex - startIndex) / 2 + 1;
                }

            } while (startIndex != endIndex);

            Console.WriteLine("Not found");
        }
    }
}

