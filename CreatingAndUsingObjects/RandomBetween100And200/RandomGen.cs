using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
