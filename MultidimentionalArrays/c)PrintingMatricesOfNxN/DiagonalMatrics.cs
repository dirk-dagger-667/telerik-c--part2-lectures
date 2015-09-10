using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//7 11 14 16
//4 8 12 15
//2 5 9 13
//1 3 6 10

namespace PrintingMatricesOfNxN
{
    class DiagonalMatrics
    {
        static void Main(string[] args)
        {

            int numberN = int.Parse(Console.ReadLine());
            int[,] sidewaysMatrics = new int[numberN,numberN];
            int counter = 0;

            for (int sidewaysIterations = 0; sidewaysIterations <= 2 * numberN - 2; sidewaysIterations++)
            {
                if(sidewaysIterations < numberN)
                {
                    for (int row = numberN - 1 - sidewaysIterations, col = 0; row < numberN; row++, col++)
                    {
                        counter++;
                        sidewaysMatrics[row, col] = counter;
                    }
                }

                if (sidewaysIterations >= numberN)
                {
                    for (int row = 0, col = (sidewaysIterations - numberN) + 1; row < numberN && col < numberN; row++, col++)
                    {
                        counter++;
                        sidewaysMatrics[row, col] = counter;
                    }
                }
            }

            for (int i = 0; i < numberN; i++)
            {
                for (int j = 0; j < numberN; j++)
                {
                    Console.Write(sidewaysMatrics[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
