using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

namespace MaxSumOf3x3SubMatrice
{
    class MaxSum3x3
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int maxSum = 0;
            int[,] MatriceForAnalysing = new int[numberN,numberM];
            int bestRow = 0;
            int bestCol = 0;

            for (int i = 0; i < numberN; i++)
			{
			    for (int j = 0; j < numberM; j++)
			    {
                    Console.WriteLine("Write the [{0},{1}] element of the matrice : ", i, j);
			        MatriceForAnalysing[i,j] = int.Parse(Console.ReadLine());
			    }
			}

            for (int row = 1; row < numberN - 1; row++)
            {
                int currentSum = 0;

                for (int col = 1; col < numberM - 1; col++)
                {
                    currentSum = MatriceForAnalysing[row - 1, col - 1] +
                        MatriceForAnalysing[row - 1, col] +
                        MatriceForAnalysing[row - 1, col + 1] +
                        MatriceForAnalysing[row, col - 1] +
                        MatriceForAnalysing[row, col] +
                        MatriceForAnalysing[row, col + 1] +
                        MatriceForAnalysing[row + 1, col - 1] +
                        MatriceForAnalysing[row + 1, col] +
                        MatriceForAnalysing[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine(maxSum);
            Console.WriteLine("{0} {1} {2}", MatriceForAnalysing[bestRow - 1, bestCol - 1], MatriceForAnalysing[bestRow - 1, bestCol], MatriceForAnalysing[bestRow - 1, bestCol + 1]);
            Console.WriteLine("{0} {1} {2}", MatriceForAnalysing[bestRow, bestCol - 1], MatriceForAnalysing[bestRow, bestCol], MatriceForAnalysing[bestRow, bestCol + 1]);
            Console.WriteLine("{0} {1} {2}", MatriceForAnalysing[bestRow + 1, bestCol - 1], MatriceForAnalysing[bestRow + 1, bestCol], MatriceForAnalysing[bestRow + 1, bestCol + 1]);
        }
    }
}
