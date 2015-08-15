using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSentancesWithTheWordInInThem
{
    class SentancesExtraction
    {
        static string ExtractSentances(string text, string keyWord)
        {
            StringBuilder extractedSentances = new StringBuilder();

            string[] splitSentancesArray = text.Split('.');
            for (int i = 0; i < splitSentancesArray.Length; i++)
            {
                if (splitSentancesArray[i].IndexOf(keyWord) != -1)
                {
                    extractedSentances.Append(splitSentancesArray[i]);
                    extractedSentances.Append(".");
                    extractedSentances.Append("\n");
                }
            }
            return extractedSentances.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write the text you want to search the sentances of : ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the the word you want to be your key for sorting the sentances : ");
            string keyWord = Console.ReadLine();

            Console.WriteLine(ExtractSentances(text, keyWord));
        }
    }
}
