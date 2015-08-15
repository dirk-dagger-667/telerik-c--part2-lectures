using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EachCharInTextToHex
{
    class UnicodeConverts
    {
        static string ConvertingStringToUnicode(string text)
        {
            StringBuilder unicodedText = new StringBuilder();
            StringBuilder unicodedChar = new StringBuilder();


            for (int i = 0; i < text.Length; i++)
            {
                unicodedChar.Append(@"\n");
                unicodedChar.Append(((int)text[i]).ToString("X4"));
                unicodedText.Append(unicodedChar);
            }

            return unicodedText.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text you want to change to Unicode : ");
            string text = Console.ReadLine();

            Console.WriteLine(ConvertingStringToUnicode(text));
        }
    }
}
