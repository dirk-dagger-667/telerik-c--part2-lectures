using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
