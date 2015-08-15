using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
