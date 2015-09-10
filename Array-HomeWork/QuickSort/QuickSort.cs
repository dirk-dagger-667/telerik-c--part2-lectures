using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).


namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            string inputArrayOne = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };
            string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            int[] unsorted = new int[inputOne.Length];
            for (int i = 0; i < inputOne.Length; i++)
            {
                unsorted[i] = int.Parse(inputOne[i]);
            }

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            Quicksort(unsorted, 0, unsorted.Length - 1);

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left;
            int j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = elements[i];
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
