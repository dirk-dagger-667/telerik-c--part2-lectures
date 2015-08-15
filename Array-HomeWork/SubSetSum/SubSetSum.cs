﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSetSum
{
    class SubSetSum
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string arrayInput = Console.ReadLine();
            char[] delimiter = new char[] {',',' '};
            string[] stringArray = arrayInput.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
            int[] numericArray = new int[stringArray.Length];

            for (int i = 0; i < numericArray.Length; i++)
            {
                numericArray[i] = int.Parse(stringArray[i]);
            }

            int currentSum = 0;
            int startOfSequence = 0;
            int endOfsequence = 0;
            for (int i = 0; i < numericArray.Length; i++)
            {
                for (int j = i; j < numericArray.Length; j++)
                {
                    currentSum += numericArray[j];

                    if (currentSum == sum)
                    {
                        startOfSequence = i;
                        endOfsequence = j;
                        for (int k = startOfSequence; k <= endOfsequence; k++)
                        {
                            Console.Write(numericArray[k] + " ");
                        }
                    }
                }
                currentSum = 0;
            }
            Console.WriteLine();
        }
    }
}
