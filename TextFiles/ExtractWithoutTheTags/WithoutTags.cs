﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>


namespace ExtractWithoutTheTags
{
    class WithoutTags
    {
        static void ExtractingWithoutTags(string pathToFile)
        {
            using (StreamReader input = new StreamReader(pathToFile))
            {
                for (int i; (i = input.Read()) != -1; )
                {
                    if (i == '>')
                    {
                        string text = String.Empty;

                        while ((i = input.Read()) != -1 && i != '<')
                        {
                            text += (char)i;
                        }

                        if (!String.IsNullOrWhiteSpace(text))
                        {
                            Console.WriteLine(text.Trim());
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            ExtractingWithoutTags(filePath);
        }
    }
}
