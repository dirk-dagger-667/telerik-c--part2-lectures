using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//    N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


namespace Combination.v2
{
    class Combination
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] permutationElements = new int[n];
            for (int i = 0; i < n; i++)
            {
                permutationElements[i] = i + 1;
            }
            int[] factorialNumbers = new int[n];
            bool[] used = new bool[n];
            bool permEnd = false;
            int currIndex = n - 1;
            while (!permEnd)
            {
                for (int i = 0; i < k; i++)
                {
                    int countOfUsed = -1;
                    for (int j = 0; j < n; j++)
                    {
                        if (!used[j])
                        {
                            countOfUsed++;
                            if (countOfUsed == factorialNumbers[i])
                            {
                                Console.Write(permutationElements[j]);
                                if (i < n - 1)
                                {
                                    Console.Write(" ");
                                }
                                used[j] = true;
                            }
                        }
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    used[i] = false;
                }

                factorialNumbers[currIndex]++;

                if (factorialNumbers[currIndex] > n - currIndex - 1)
                {
                    while (factorialNumbers[currIndex] > n - currIndex - 1)
                    {
                        factorialNumbers[currIndex] = 0;
                        currIndex--;
                        if (currIndex >= 0)
                        {
                            factorialNumbers[currIndex]++;
                        }
                        else
                        {
                            permEnd = true;
                            break;
                        }
                    }
                    currIndex = n - 1;
                }

            }
        }
    }
}
