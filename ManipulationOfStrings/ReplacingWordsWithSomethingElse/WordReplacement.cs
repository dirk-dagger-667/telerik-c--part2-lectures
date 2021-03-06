﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//        Words: "PHP, CLR, Microsoft"
//        The expected result:
//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace ReplacingWordsWithSomethingElse
{
    class WordReplacement
    {
        static string CensoringTextUsingKeyWords(string text, string censoringWords)
        {
            string[] listOfWords = text.Split(new Char [] {',',' '},StringSplitOptions.RemoveEmptyEntries);
            StringBuilder censoredText = new StringBuilder();
            censoredText.Append(text);

            for (int i = 0; i < listOfWords.Length; i++)
            {
                censoredText = censoredText.Replace(listOfWords[i], new String ('*', listOfWords[i].Length));
            }

            return censoredText.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text you want to censor : ");
            string text = Console.ReadLine();
            Console.WriteLine(@"Enter the words for censoring seperating them using "","" and "" "" : ");
            string censoringWords = Console.ReadLine();

            Console.WriteLine(CensoringTextUsingKeyWords(text, censoringWords));
        }
    }
}
