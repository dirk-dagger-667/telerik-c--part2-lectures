using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinToDec
    {
        static decimal ConvertBinaryToDecimal(string binaryValue)
        {
            int digit = 0;
            decimal decimalValue = 0;

            for (int i = 0; i < binaryValue.Length; i++)
            {
                digit = int.Parse(binaryValue[binaryValue.Length - 1 - i].ToString());
                int power = 1;

                for (int j = 0; j < i; j++)
                {
                    power *= 2;
                }

                decimalValue += digit * power;
            }

            return decimalValue;
        }

        static void Main(string[] args)
        {
            string binaryValue = Console.ReadLine();

            Console.WriteLine(ConvertBinaryToDecimal(binaryValue));
        }
    }
}
