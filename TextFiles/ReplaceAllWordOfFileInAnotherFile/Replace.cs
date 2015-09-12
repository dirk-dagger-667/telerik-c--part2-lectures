using System;
using System.IO;
using System.Collections.Generic;
using System.Security;

//Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.


class Replace
{
    static List<string> FillingListWithWordsFromTextFile(string filePathToWordsFile)
    {
            StreamReader reader = new StreamReader(filePathToWordsFile);

            List<string> listOfWords = new List<string>();
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                listOfWords.Add(line);
            }

            return listOfWords;
    }

    static void ReplacingWordsFromListInFile(List<string> listOfWords, string pathToFileToWrite, string pathToFileToRead)
    {
        try
        {
            string line;
            List<string> newListOfWords = FillingListWithWordsFromTextFile(pathToFileToRead);

            using (StreamReader newReader = new StreamReader(pathToFileToWrite))
            {
                using (StreamWriter writer = new StreamWriter("temp.txt"))
                {
                    while ((line = newReader.ReadLine()) != null)
                    {
                        for (int i = 0; i < newListOfWords.Count; i++)
                        {
                            string word = newListOfWords[i];
                            line = line.Replace(word, " ");
                        }
                        writer.WriteLine(line);
                    }
                }
            }
            File.Delete(pathToFileToWrite);
            File.Move("temp.txt", pathToFileToWrite);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No such File found!!!!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Wrong path to File!!!!");
        }
        catch (IOException)
        {
            Console.WriteLine("Another program is using the file!!!!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null words!!!!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Wrong argument!!!!");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Cannot store anymore!!!!");
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the path of the file for reading the words");
        string readingFile = Console.ReadLine();
        Console.WriteLine("Enter the path to the file we want to replace the words of");
        string writingFile = Console.ReadLine();

        ReplacingWordsFromListInFile(FillingListWithWordsFromTextFile(readingFile), writingFile, readingFile);    
    }
}
