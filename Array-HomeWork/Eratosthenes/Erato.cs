using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthenes
{
    class Erato
    {
        static void Main(string[] args)
        {

            bool[] eratosthenes = new bool[10000000];
            int counter = 0;

            for (int i = 2; i <= Math.Sqrt(10000000); i++)
            {
                if (eratosthenes[i] == false)
                {
                    for (int j = i * i ; j < 10000000; j=i*i + counter * i)
                    {
                        eratosthenes[j] = true;
                        counter++;
                    }
                }
                counter = 0;
            }

            for (int i = 2; i < 10000000 ; i++)
            {
                if (eratosthenes[i] == false)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
