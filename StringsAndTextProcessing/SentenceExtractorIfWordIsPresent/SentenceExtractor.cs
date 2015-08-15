using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
