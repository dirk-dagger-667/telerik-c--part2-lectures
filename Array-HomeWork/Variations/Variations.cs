using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//    N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

namespace Variations
{
    class Variations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] variation = new int[k];

            for (int i = 0; i < k; i++)
            {
                variation[i] = 1;
            }

            bool combEnd = false;
            int currIndex = k - 1;

            while (!combEnd)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(variation[j]);

                    if (j < k - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
                variation[currIndex]++;

                if (variation[currIndex] > n)
                {
                    while (variation[currIndex] > n)
                    {
                        variation[currIndex] = 1;
                        currIndex--;

                        if (currIndex >= 0)
                        {
                            variation[currIndex]++;
                        }
                        else
                        {
                            combEnd = true;
                            break;
                        }
                    }

                    currIndex = k - 1;
                }
            }
        }
    }
}
