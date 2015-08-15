using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumberMethodMyApp
{
    class ReadingANumber
    {
        static void ReadNumber(int start, int end)
        {
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number < start || number > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not an integer number! Write an integer number!!!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range(must be between the start and end variables)!!!!");
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write the start of the interval");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the end of the interval");
                int end = int.Parse(Console.ReadLine());

                for (int i = 0; i < 10; i++)
                {
                    ReadNumber(start, end);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable that you've enter is not a number!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The variable cannot be null, it must have a value!");
            }
           
        }
    }
}
