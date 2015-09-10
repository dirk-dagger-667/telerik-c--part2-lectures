using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and replaces every sequence of identical letters in it with a single letter (the repeating letter). Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

namespace SingleAccuranceOfRepeatingSequentionalLetters
{
    class RedurerToSingleAccurence
    {
        public static void Reducer(string word)
        {
            if (word == null || word == string.Empty)
            {
                throw new ArgumentNullException("the word is either null or empty");
            }
            else
            {
                StringBuilder singularAccuranceString = new StringBuilder();

                for (int i = 0; i < word.Length; )
                {
                    int counterOfLetter = 0;

                    for (int j = i; j < word.Length; j++)
                    {
                        if (word[i] == word[j])
                        {
                            counterOfLetter++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (counterOfLetter > 0)
                    {
                        singularAccuranceString.Append(word[i]);
                    }

                    i += counterOfLetter;
                }

                Console.WriteLine(singularAccuranceString.ToString());
            }
        }

        static void Main(string[] args)
        {
            string wordForFormatting = "aaaaabbbbbcdddeeeedssaa";
            Reducer(wordForFormatting);
        }
    }
}
