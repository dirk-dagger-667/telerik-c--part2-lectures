using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the sequence of maximal sum in given array. Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//    Can you do it with only one loop (with single scan through the elements of the array)?


namespace LargestSumBruteForce
{
    class LargestSum
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

            int currentSum = 0;
            int maxSum = 0;
            int bestEndPosition = 0;
            int bestStartPosition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestEndPosition = j;
                        bestStartPosition = i;
                    }
                }
                currentSum = 0;
            }

            for (int i = bestStartPosition; i < bestEndPosition; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write(arr[bestEndPosition]);
        }
    }
}
