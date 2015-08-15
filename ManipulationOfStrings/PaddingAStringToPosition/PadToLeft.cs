using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddingAStringToPosition
{
    class PadToLeft
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string that's 20 characters long or less : ");
            string stringToPad = Console.ReadLine();

            if (stringToPad.Length < 20)
            {
                Console.WriteLine(stringToPad.PadRight(20,'*'));
            }

            if (stringToPad.Length > 20)
            {
                Console.WriteLine("Write 20 chars OR less!!!!");
                return;
            }
            else
            {
                Console.WriteLine(stringToPad);
            }


        }
    }
}
