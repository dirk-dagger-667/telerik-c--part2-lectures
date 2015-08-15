﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingMatricesOfNxN
{
    class SpiralMatrice
    {
        static void Main(string[] args)
        {
            int lenghtOfArray = int.Parse(Console.ReadLine());
            int start = 0;
            int end = lenghtOfArray;
            int[,] spiralMatrice = new int[lenghtOfArray, lenghtOfArray];
            int counter = 0;

            while (end - start >= 1)
            {
                for (int i = start; i < end; i++)
                {
                    counter++;
                    spiralMatrice[i,start] = counter;
                }

                for (int j = start + 1; j < end ; j++)
                {
                    counter++;
                    spiralMatrice[end - 1,j] = counter;
                }

                for (int k = end - 2; k >= start; k--)
                {
                    counter++;
                    spiralMatrice[k,end - 1] = counter;
                }

                for (int l = end - 2; l > start; l--)
                {
                    counter++;
                    spiralMatrice[start,l] = counter;
                }
                start++;
                end--;
            }

            for (int i = 0; i < lenghtOfArray; i++)
            {
                for (int j = 0; j < lenghtOfArray; j++)
                {
                    Console.Write(spiralMatrice[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
