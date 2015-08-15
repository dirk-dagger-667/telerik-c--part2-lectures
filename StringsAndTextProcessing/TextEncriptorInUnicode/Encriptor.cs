using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
