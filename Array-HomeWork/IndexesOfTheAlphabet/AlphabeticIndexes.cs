using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexesOfTheAlphabet
{
    class AlphabeticIndexes
    {
        static void Main(string[] args)
        {

            char[] alphabet = new char[26] 
            { 
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 
                'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 
                'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                'Y', 'Z'
            };
            Console.WriteLine("Write the word in CAPITAL letters : ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                    Console.WriteLine(Array.BinarySearch(alphabet,word[i]));
            }
        }
    }
}
