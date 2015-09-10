using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all sentences containing given word.
//        Example: The word is "in". The text is:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//        The expected result is:
//We are living in a yellow submarine.
//We will move out of it in 5 days.
//        Consider that the sentences are separated by "." and the words – by non-letter symbols.

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
