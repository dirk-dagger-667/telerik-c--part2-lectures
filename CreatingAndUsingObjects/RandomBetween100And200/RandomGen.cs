using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace RandomBetween100And200
{
    class RandomGen
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(randomGenerator.Next(99,201));
            }
        }
    }
}
