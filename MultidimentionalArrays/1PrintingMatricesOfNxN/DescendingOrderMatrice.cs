﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingMatricesofNxN
{
    class DescendingOrderMatrix
    {
        static void Main(string[] args)
        {

            int numberN = int.Parse(Console.ReadLine());
            int[,] descendingOrderMatrics = new int[numberN, numberN];
            int counter = 0;

            for (int col = 0; col < numberN; col++)
            {
                for (int row = 0; row < numberN; row++)
                {
                    counter++;
                    descendingOrderMatrics[col, row] = counter;
                }
            }

            for (int i = 0; i < numberN; i++)
            {
                for (int j = 0; j < numberN; j++)
                {
                    Console.Write(descendingOrderMatrics[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

