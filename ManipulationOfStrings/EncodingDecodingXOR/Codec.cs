using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

namespace EncodingDecodingXOR
{
    class Codec
    {
        static string EncodingDecoding(string forCoDec, string key)
        {
            StringBuilder encodedDecoded = new StringBuilder();
            int counter = 0;

            for (int i = 0; i < forCoDec.Length; i++)
            {
                if (counter == key.Length)
                {
                    counter = 0;
                }
                encodedDecoded.Append((char)(forCoDec[i] ^ key[counter]));
                counter++;
            }

            return encodedDecoded.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text for encryption : ");
            string forEncryption = Console.ReadLine();
            Console.WriteLine("Enter the cipher(key) : ");
            string stringKey = Console.ReadLine();

            Console.WriteLine(EncodingDecoding(forEncryption,stringKey));
        }
    }
}
