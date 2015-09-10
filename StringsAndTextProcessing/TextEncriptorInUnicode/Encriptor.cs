using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encrypts a text by applying XOR (excluding or) operation between the given source characters and given cipher code. The encryption should be done by applying XOR between the first letter of the text and the first letter of the code, the second letter of the text and the second letter of the code, etc. until the last letter of the code, then goes back to the first letter of the code and the next letter of the text. Print the result as a series of Unicode escape characters \xxxx.
//Sample source text: "Test". Sample cipher code: "ab". The result should be the following: "\u0035\u0007\u0012\u0016".

namespace TextEncriptorInUnicode
{
    class Encriptor
    {
        public static void Encript(string inputText, string key)
        {
            if (inputText == null || inputText == String.Empty)
            {
                throw new ArgumentNullException("The input text is null or empty!");
            }
            else if (key == null || key == String.Empty)
            {
                throw new ArgumentNullException("The incription key text is null or empty!");
            }
            else
            {
                int letterOfKeyCount = 0;
                StringBuilder encriptedText = new StringBuilder();

                for (int letterOfTextCount = 0;  letterOfTextCount < inputText.Length; letterOfTextCount++)
                {
                    ushort letterOfInputText = inputText[letterOfTextCount];
                    ushort letterOfKey = key[letterOfKeyCount];
                    ushort XORedLetter = (ushort)(letterOfInputText ^ letterOfKey);
                    encriptedText.Append(String.Format(@"\u{0:x4}", XORedLetter));
                }

                Console.WriteLine(encriptedText.ToString());
            }
        }

        static void Main(string[] args)
        {
            string inputText = "Test";
            string key = "ab";

            Encript(inputText, key);
        }
    }
}
