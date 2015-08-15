using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingATextFileAlphabetically
{
    class SortingTextFiles
    {
        static List<string> TextFileToStringArray(string pathToFileForReading)
        {
            using (StreamReader reader = new StreamReader(pathToFileForReading))
            {
                List<string> listOfLines = new List<string>();

                for (string line; (line = reader.ReadLine()) != null;)
                {
                    listOfLines.Add(line);
                }

                return listOfLines;
            }
        }

        static void WritingListToFile(List<string> sortedList, string pathToFileForWriting)
        {
            using(StreamWriter writer = new StreamWriter(pathToFileForWriting))
            {
                for (int i = 0; i < sortedList.Count; i++)
                {
                    writer.WriteLine(sortedList[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the file for reading : ");
            string pathToFileForReading = Console.ReadLine();
            Console.WriteLine("Enter the path where we'd like to write the file with the sorted lines : ");
            string pathToFileForWriting = Console.ReadLine();
            List<string> listOfLines = new List<string>(TextFileToStringArray(pathToFileForReading));

            listOfLines.Sort();

            WritingListToFile(listOfLines,pathToFileForWriting);
        }
    }
}
