using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Search for information in Internet and define your own class for exception FileParseException. The exception has to contain the name of the processed file and the number of the row where the problem is occurred. Add appropriate constructors in the exception. Write a program that reads integers from a text file. If the during reading a row does not contain an integer throw FileParseException and pass it to the calling method.

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
