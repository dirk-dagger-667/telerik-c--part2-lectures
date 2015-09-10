using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reverses the words in a given sentence without changing punctuation and spaces. For example: "C# is not C++ and PHP is not Delphi"  "Delphi not is PHP and C++ not is C#".

namespace ReversingThePlacingOfWordsInString
{
    class Reverser
    {
        public static void ReversingThePlacementOfWords(string inputText)
        {
            if (inputText == null || inputText == string.Empty)
            {
                throw new ArgumentNullException("The text for reversing is either null or empty!");
            }
            else
            {
                string[] stringToStringArray = inputText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder reversedString = new StringBuilder();

                for (int i = 0; i < stringToStringArray.Length; i++)
                {
                    if (i < stringToStringArray.Length - 1)
                    {
                        reversedString.Append(stringToStringArray[stringToStringArray.Length - 1 - i]);
                        reversedString.Append(" ");
                    }
                    else
                    {
                        reversedString.Append(stringToStringArray[stringToStringArray.Length - 1 - i]);
                    }
                    
                }

                Console.WriteLine(reversedString.ToString());
            }
        }

        static void Main(string[] args)
        {
            string inputText = "C# is not C++ and PHP is not Delphi";
            ReversingThePlacementOfWords(inputText);
        }
    }
}
