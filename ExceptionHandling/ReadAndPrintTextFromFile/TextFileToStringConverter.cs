using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program to download a file from Internet by given URL, e.g. http://introprogramming.info/wp-content/themes/introprograming_en/ images/Intro-Csharp-Book-front-cover-big_en.png.

namespace ReadAndPrintTextFromFile
{
    class TextFileToStringConverter
    {
        public static string TextFileToString(string textFilePath)
        {
            StringBuilder textFromFile = new StringBuilder();
            string line;

            using (StreamReader reader = new StreamReader(textFilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    textFromFile.Append(line);
                    textFromFile.Append("\n");
                }
            }

            return textFromFile.ToString();
        }

        static void Main(string[] args)
        {
            try
            {
                string textFilePath = Console.ReadLine();
                string textOfFile = TextFileToString(textFilePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file doesn't exist");
            }
            catch(FileLoadException)
            {
                Console.WriteLine("The file exist, but cannot be loaded");
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("The path to the file is longer that the maximum allowed of 256 characters");
            }
            catch(DriveNotFoundException)
            {
                Console.WriteLine("The drive you're trying to access is doesn't exist");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("The directory doesn't exist");
            }
        }
    }
}
