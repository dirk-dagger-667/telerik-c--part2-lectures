using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
