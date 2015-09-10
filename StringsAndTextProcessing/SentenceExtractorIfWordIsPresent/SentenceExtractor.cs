using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a text all sentences that contain a particular word. We accept that the sentences are separated from each other by the character "." and the words are separated from one another by a character which is not a letter. Sample text:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinkingall the day. We will move out of it in 5 days.
//Sample result:
//We are living in a yellow submarine.
//We will move out of it in 5 days.

namespace SentenceExtractorIfWordIsPresent
{
    class SentenceExtractor
    {
        const char seperator = '.';

        public static void FindSentancesContainingWord(string inputText, string keyword)
        {
            if (inputText == null || inputText == String.Empty)
            {
                throw new ArgumentNullException("The text for input is null or empty");
            }
            else if (keyword == null || keyword == String.Empty)
            {
                throw new ArgumentNullException("The key word is null or empty");
            }
            else
            {
                string[] seperatedSentances = inputText.Split(new char[] { seperator }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < seperatedSentances.Length; i++)
                {
                    if (seperatedSentances[i].Contains(keyword))
                    {
                        Console.WriteLine(seperatedSentances[i]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string inputText = @"We are living in a yellow submarine. We don't have anything else.
Inside the submarine is very tight. So we are drinking
all the day. We will move out of it in 5 days.";
            string keyword = " " + Console.ReadLine() + " ";

            FindSentancesContainingWord(inputText, keyword);
        }
    }
}
