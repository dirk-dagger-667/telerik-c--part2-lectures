using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingMatricesOfNxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int[,] descendingOrderMatrics = new int[numberN, numberN];
            int counter = 0;

            for (int col = 0; col < numberN; col++)
            {
                if (col%2 == 0)
                {
                    for (int descendingRow = 0; descendingRow < numberN; descendingRow++)
                    {
                        counter++;
                        descendingOrderMatrics[col, descendingRow] = counter;
                    }
                }

                else
                {
                    for (int ascendingRow = numberN - 1; ascendingRow >=0; ascendingRow--)
                    {
                        counter++;
                        descendingOrderMatrics[col, ascendingRow] = counter;
                    }
                }
            }

            for (int i = 0; i < numberN; i++)
            {
                for (int j = 0; j < numberN; j++)
                {
                    Console.Write(descendingOrderMatrics[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
