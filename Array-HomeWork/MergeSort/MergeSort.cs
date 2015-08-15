using System;
using System.Linq;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
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
            arr = MergeSortArray(arr);

            PrintArray(arr);
        }

        private static void PrintArray(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine("{0} ", numbersArray[i]);
            }
        }

        static int[] MergeSortArray(int[] arrayToSort)
        {
            return (MergeSortList(arrayToSort.ToList<int>())).ToArray<int>();
        }

        static List<int> MergeSortList(List<int> ListToSort)
        {
            if (ListToSort.Count <= 1)
            {
                return ListToSort;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> result = new List<int>();

            int middle = ListToSort.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(ListToSort[i]);
            }

            for (int i = middle; i < ListToSort.Count; i++)
            {
                right.Add(ListToSort[i]);
            }
            left = MergeSortList(left);
            right = MergeSortList(right);
            result = Merge(left, right);
            return result;
        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            return result;
        }
    }
}
