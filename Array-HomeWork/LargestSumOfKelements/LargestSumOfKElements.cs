using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


namespace LargestSumOfKelements
{
    class LargestSumOfKElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N : ");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Nubmer K : ");
            int numberK = int.Parse(Console.ReadLine());

            if (numberK < numberN)
            {
                int[] arrayOfNumbersN = new int[numberN];

                for (int i = 0; i < numberN; i++)
                {
                    Console.WriteLine("Enter the {0} element of the Array : ",i);
                    arrayOfNumbersN[i] = int.Parse(Console.ReadLine());
                }
                int currentSum = 0;
                int maxSum = 0;
                int bestIndex = 0;
                for (int i = 0; i <= numberN - numberK; i++)
                {
                    for (int j = i; j < numberK + i; j++)
                    {
                        currentSum += arrayOfNumbersN[j];
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestIndex = i;
                    }
                    currentSum = 0;
                }

                for (int i = bestIndex; i < numberK + bestIndex - 1; i++)
                {
                    Console.Write(arrayOfNumbersN[i] + ", ");
                }
                Console.Write(arrayOfNumbersN[numberK + bestIndex - 1]);

            }

            else
            {
                Console.WriteLine("K must be smaller than N");
            }

        }
    }
}
