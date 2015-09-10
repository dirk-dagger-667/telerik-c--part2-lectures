using System;

//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace MostFrequentNumber
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

            int tempCounter = 1;
            int counter = 0;
            int index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        tempCounter++;
                    }
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    index = i;
                }
                tempCounter = 0;

            }
            Console.WriteLine(arr[index] + "  " + counter + " times");
        }
    }
}
