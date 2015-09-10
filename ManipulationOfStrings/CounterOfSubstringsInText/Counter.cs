using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//        Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//    The result is: 9.

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
