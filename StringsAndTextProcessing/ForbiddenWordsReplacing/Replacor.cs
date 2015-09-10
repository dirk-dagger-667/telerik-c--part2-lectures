using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A string is given, composed of several "forbidden" words separated by commas. Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks. Sample text:
//Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.
//Sample string containing the forbidden words: "C#,CLR,Microsoft".
//Sample result:
//********* announced its next generation ** compiler today. It uses advanced parser and special optimizer for the ********* ***.

namespace ForbiddenWordsReplacing
{
    class Replacor
    {
        const char seperator = ',';

        public static void ReplacingWords(string forbiddenWordsInput, string inputText)
        {
            string[] forbiddenWords = forbiddenWordsInput.Split(new char[] {seperator}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < forbiddenWords.Length; i++)
			{
                inputText = inputText.Replace(forbiddenWords[i], new String('*', forbiddenWords[i].Length));
			}

            Console.WriteLine(inputText);
        }

        static void Main(string[] args)
        {
            string inputText = @"Microsoft announced its next generation C# compiler today.
It uses advanced parser and special optimizer for the Microsoft CLR.";
            string forbiddenWordsInput = "C#,CLR,Microsoft";
            ReplacingWords(forbiddenWordsInput, inputText);
        }
    }
}
