using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that concatenates two text files into another text file.


namespace TextFiles2in1
{
    class TwoInOne
    {
        const string OUTPUT_FILE = "concatenatedFile.txt";

        static void Merging2TextFilesIn1(string pathToFirstFile, string pathToSecondFile)
        {
            try
            {
                StreamReader firstFileForExtracting = new StreamReader(pathToFirstFile);
                StreamReader secondFileForExtracting = new StreamReader(pathToSecondFile);
                StreamWriter concatenatedFile = new StreamWriter(OUTPUT_FILE);

                using (concatenatedFile)
                {
                    using (firstFileForExtracting)
                    {
                        string line;

                        while ((line = firstFileForExtracting.ReadLine()) != null)
                        {
                            concatenatedFile.WriteLine(line);
                        }
                    }

                    using (secondFileForExtracting)
                    {
                        string line;

                        while ((line = secondFileForExtracting.ReadLine()) != null)
                        {
                            concatenatedFile.WriteLine(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("One or both of the source files do NOT EXIST");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("One of both of the paths of the source files are INCORRECT");
            }
            catch(IOException)
            {
                Console.WriteLine("The file for merging cannot be accessed");
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of the first file : ");
            string filePathFirstFile = Console.ReadLine();
            Console.WriteLine("Enter the path to the second file : ");
            string filePathSecondFile = Console.ReadLine();

            Merging2TextFilesIn1(filePathFirstFile, filePathSecondFile);
        }
    }
}
