using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A dictionary is given, which consists of several lines of text. Each line consists of a word and its explanation, separated by a hyphen:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET namespace – hierarchical organization of classes
//Write a program that parses the dictionary and then reads words from the console in a loop, gives an explanation for it or writes a message on the console that the word is not into the dictionary.

namespace DictionaryParsing
{
    class ParserOfDictionaries
    {
        const char separator = '-';

        public static void ParsingFromDictionary(string dictionary, string keyword)
        {
            if (dictionary == null || dictionary == string.Empty)
            {
                throw new ArgumentNullException("The dictionary is nul or empty");
            }
            else if (dictionary.IndexOf(separator) == -1)
            {
                throw new FormatException("The dictionary is not in the correct format, because are no separators between the word and the explanaition of it!");
            }
            else
            {
                string[] devidedDictionary = dictionary.Split(new char[] { separator, '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < devidedDictionary.Length; i += 2)
                {
                    if (devidedDictionary[i].Trim().ToLower() == keyword.ToLower())
                    {
                        Console.WriteLine(devidedDictionary[i + 1].Trim());
                    }
                    else if (i == devidedDictionary.Length)
                    {
                        Console.WriteLine("No such word in dictionary");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string inputDictionary = @".NET - platform for applications from Microsoft
CLR - managed execution environment for .NET 
namespace - hierarchical organization of classes";
            string keyword = string.Empty;

            while (keyword != "end")
            {
                keyword = Console.ReadLine();
                ParsingFromDictionary(inputDictionary, keyword);
            }
        }
    }
}
