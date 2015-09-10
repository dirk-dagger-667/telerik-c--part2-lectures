using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and prints in alphabetical order all letters from the input string and how many times each one of them occurs in the string.

namespace LetterOrderingAndCounting
{
    class OrdererAndCounter
    {
        public static void OrderAndCount(string textAsString)
        {
            if (textAsString == null || textAsString == string.Empty)
            {
                throw new ArgumentNullException("string is null or empty");
            }
            else
            {
                string caseInsensetive = textAsString.ToLower();
                for (int i = 0; i < 26; i++)
                {
                    char letterFromAlphabet = (char)(97 + i);
                    int indexOfStarting = 0;
                    int counter = 0;

                    while (caseInsensetive.IndexOf(letterFromAlphabet, indexOfStarting) != -1)
                    {
                        counter++;
                        indexOfStarting = caseInsensetive.IndexOf(letterFromAlphabet, indexOfStarting) + 1;
                    }

                    if (counter > 0)
                    {
                        Console.WriteLine("{0} - {1}", letterFromAlphabet, counter);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string text = "The US government confirms that an American man believed to have been fighting alongside Islamist militants in Syria has been killed; the total number of Americans killed while taking part in the civil war rises to three.";
            OrderAndCount(text);
        }
    }
}
