using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.


namespace PrintingName
{
    class PrintingName
    {
        static void PrintinYourgName()
        {
            Console.WriteLine("Whrite your name below so that I can say Hi to you");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello, " + yourName);

        }

        static void Main(string[] args)
        {
            PrintinYourgName();
        }
    }
}
