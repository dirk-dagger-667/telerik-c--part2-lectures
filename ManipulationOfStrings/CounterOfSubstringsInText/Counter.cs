using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterOfSubstringsInText
{
    class Counter
    {
        static int CountingAccurancesOfSubstringsInText(string text)
        {
            Console.WriteLine("Enter the substring you want to search for : ");
            string keyword = Console.ReadLine();
            int i = 0;

            for (int index = text.IndexOf(keyword); index >= 0; index = text.IndexOf(keyword, index + 1))
            {
                i++;
            }

            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write the text you want to search in : ");
            string text = Console.ReadLine().ToLower();
            
            Console.WriteLine(CountingAccurancesOfSubstringsInText(text));
        }
    }
}
