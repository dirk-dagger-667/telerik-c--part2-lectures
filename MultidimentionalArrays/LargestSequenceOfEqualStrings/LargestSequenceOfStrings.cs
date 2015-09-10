using System;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:
//ha fifi ho hi                s qq s
//for ha hi xx -> ha, ha, ha   pp pp s -> s, s, s  
//xxx ho ha xx                 pp qq s

class LongestSequenceOfEqualStringInMatrix
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());
        string[,] array = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("array[{0},{1}]: ", i, j);
                array[i, j] = Console.ReadLine();
            }
        }
        int maxSequenceXIndex = 0;
        int maxSequenceYIndex = 0;
        int maxSequenceLength = 1;
        string maxSequenceType = "none";
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                string elementToCheck = array[i, j];
                int currentLength = 1;
                int rowSequence = i + 1;
                while (rowSequence < n)
                {
                    if (elementToCheck == array[rowSequence, j])
                    {
                        currentLength++;
                        rowSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    maxSequenceType = "row";
                    maxSequenceLength = currentLength;
                }

                currentLength = 1;
                int lineSequence = j + 1;
                while (lineSequence < m)
                {
                    if (elementToCheck == array[i, lineSequence])
                    {
                        currentLength++;
                        lineSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    maxSequenceType = "line";
                    maxSequenceLength = currentLength;
                }

                currentLength = 1;
                int diagonalX = i + 1;
                int diagonalY = j + 1;
                while (diagonalX < n && diagonalY < m)
                {
                    if (elementToCheck == array[diagonalX, diagonalY])
                    {
                        currentLength++;
                        diagonalX++;
                        diagonalY++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentLength > maxSequenceLength)
                {
                    maxSequenceXIndex = i;
                    maxSequenceYIndex = j;
                    maxSequenceType = "diagonal";
                    maxSequenceLength = currentLength;
                }
            }
        }
        if (maxSequenceType == "none")
        {
            Console.WriteLine("No sequences");
        }
        else
        {
            for (int i = 0; i < maxSequenceLength; i++)
            {
                Console.Write(array[maxSequenceXIndex, maxSequenceYIndex] + " ");
            }
        }
    }
}

