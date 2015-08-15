using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumberMyApp
{
    class Program
    {
        static void Sqrt(int number)
        {
            try
            {
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double sqrt = Math.Sqrt(number);
                Console.WriteLine(sqrt);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("INVALID NUMBER !!!!!!");
            }
            finally
            {
                Console.WriteLine("Good Bey!!!!");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number(must be non-negative) : ");
                int number = int.Parse(Console.ReadLine());

                Sqrt(number);
            }
            catch (OverflowException)
            {
                Console.WriteLine("INVALID NUMBER !!!!");
            }
        }
    }
}
