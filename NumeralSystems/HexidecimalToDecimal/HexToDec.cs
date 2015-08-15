using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexidecimalToDecimal
{
    class HexToDec
    {
        static int ConvertHexadecimalToDecimal(string hexadecimalValue)
        {
            int num = Int32.Parse(hexadecimalValue, System.Globalization.NumberStyles.HexNumber);
            return num;
        }

        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();

            Console.WriteLine(ConvertHexadecimalToDecimal(hexNumber));
        }
    }
}
