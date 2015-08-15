using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintOddLinesOfTextFiles
{
    class OddLinesInTextFile
    {
        static void PrintOddLines(string filePath)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);

                using (reader)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;
                        if (lineNumber % 2 == 1)
                        {
                            Console.WriteLine("The {0} line is : {1}", lineNumber, line);    
                        }
                        line = reader.ReadLine();
                    }
                }
            }

            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("A file by that name doesn't exist {0}", filePath);
            }

            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Wrong directory path {0}", filePath);
            }

            catch (IOException)
            {
                Console.Error.WriteLine("Can't open the file {0}", filePath);
            }
        }

        static void Main(string[] args)
        {
            string filePath = @"TextFile.txt";

            PrintOddLines(filePath);
        }
    }
}
