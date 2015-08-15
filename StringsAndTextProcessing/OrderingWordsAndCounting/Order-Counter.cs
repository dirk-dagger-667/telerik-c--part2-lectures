using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingWordsAndCounting
{
    class Program
    {
        public static void OrderingAndCountingWords(string text)
        {
            if (text == null || text == string.Empty)
            {
                throw new ArgumentNullException("the text is either null or empty");
            }
            else
            {
                string[] stringToArray = text.Split(new char[] { ' ', ',', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort<string>(stringToArray);

                for (int i = 0; i < stringToArray.Length; i++)
                {
                    int counterOfWords = 0;

                    if (stringToArray[i] != string.Empty)
                    {
                        string currentWord = stringToArray[i];

                        for (int j = i; j < stringToArray.Length; j++)
                        {
                            if (currentWord == stringToArray[j])
                            {
                                counterOfWords++;
                                stringToArray[j] = string.Empty;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (counterOfWords > 0)
                        {
                            Console.WriteLine("{0} - {1}", currentWord, counterOfWords);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string text = "Write a program that reads a string from the console and prints in alphabetical order all words from the input string and how many times each one of them occurs in the string.";
            OrderingAndCountingWords(text);
        }
    }
}
