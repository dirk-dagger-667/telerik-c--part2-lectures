using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SumOf2x2OfMatrixFromTextFile
{
    class SumOf2x2
    {
        static int[,] TextFileToStringArray(string pathToFileForReading)
        {
            using (StreamReader input = new StreamReader(pathToFileForReading))
            {
                int numberOfRows = int.Parse(input.ReadLine());
                int[,] matrix = new int[numberOfRows, numberOfRows];

                for (int i = 0; i < numberOfRows; i++)
                {
                    string[] numbers = input.ReadLine().Split(' ');

                    for (int j = 0; j < numberOfRows; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }

                return matrix;
            }
        }

        static int GetMaxSumOfFourNeighbors(int[,] matrix)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    maxSum = Math.Max(maxSum, matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
                }
            }

            return maxSum;
        }

        static void WriteSumToFile(int maxSum, string pathToFileForWriting)
        {
            using (StreamWriter output = new StreamWriter(pathToFileForWriting))
            {
                output.WriteLine(maxSum);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path for the file that we want to read from : ");
            string pathToFileForReading = Console.ReadLine();
            Console.WriteLine("Enter the path for the file we want to write to : ");
            string pathToFileForWriting = Console.ReadLine();

            int[,] matrix = TextFileToStringArray(pathToFileForReading);
            int sum = GetMaxSumOfFourNeighbors(matrix);
            WriteSumToFile(sum, pathToFileForWriting);
        }
    }
}

