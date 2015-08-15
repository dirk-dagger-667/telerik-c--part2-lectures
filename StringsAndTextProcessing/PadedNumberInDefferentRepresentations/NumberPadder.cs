using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace PadedNumberInDefferentRepresentations
{
    class NumberPadder
    {
        public static void RepresentingNumber(string numberString)
        {
            double doubleNumber;

            if (double.TryParse(numberString, out doubleNumber) == true)
            {
                Console.WriteLine(String.Format("{0:###############}", doubleNumber).PadLeft(15));
                Console.WriteLine(doubleNumber.ToString("C").PadLeft(15));
                Console.WriteLine(doubleNumber.ToString("P").PadLeft(15));
                Console.WriteLine(doubleNumber.ToString("E").PadLeft(15));
                byte[] bytes = BitConverter.GetBytes(doubleNumber);
                Console.WriteLine(BitConverter.ToString(bytes));
            }
            else
            {
                throw new ArgumentException("the input is not a number!");
            }
        }

        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            RepresentingNumber(numberInput);
        }
    }
}
