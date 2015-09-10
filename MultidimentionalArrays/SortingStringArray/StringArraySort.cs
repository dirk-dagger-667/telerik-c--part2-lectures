using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            string inputArrayOne = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };
            string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();

            Quicksort(inputOne, 0, inputOne.Length - 1);

            for (int i = 0; i < inputOne.Length; i++)
            {
                Console.Write(inputOne[i] + " ");
            }
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left;
            int j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].Length < pivot.ToString().Length)
                {
                    i++;
                }

                while (elements[j].Length > pivot.ToString().Length )
                {
                    j--;
                }

                if (i <= j)
                {
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }

        }
    }
}
