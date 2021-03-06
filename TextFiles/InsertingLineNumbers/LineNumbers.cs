﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.


namespace InsertingLineNumbers
{
    class LineNumbers
    {
        static void ShowLineNumbersInTextFile(string pathToFile)
        {
            using (StreamReader reader = new StreamReader(pathToFile))
            {
                using (StreamWriter writer = new StreamWriter("NumberedFile.txt"))
                {
                    int counter = 1;

                    for (string line; ((line = reader.ReadLine()) != null); counter++)
                    {
                        writer.WriteLine("{0} {1}", counter, line);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the file : ");
            string pathToFile = Console.ReadLine();

            ShowLineNumbersInTextFile(pathToFile);
        }
    }
}
