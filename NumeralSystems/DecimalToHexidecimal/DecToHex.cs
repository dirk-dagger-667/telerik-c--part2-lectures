using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.


namespace DecimalToHexidecimal
{
    class DecToHex
    {
        static string ConvertDecimalToHexidecimal(int decimalValue)
        {
            string hexidecimalValue = string.Format("{0:x}",decimalValue);
            return hexidecimalValue;
        }

        static void Main(string[] args)
        {
            int decimalValue = int.Parse(Console.ReadLine());

            Console.WriteLine(ConvertDecimalToHexidecimal(decimalValue));
        }
    }
}
