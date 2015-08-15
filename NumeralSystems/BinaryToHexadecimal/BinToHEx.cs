using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class BinToHEx
    {
        static string ConvertBinaryToHeaxadecimal(string binValue)
        {
            int digit = 0;
            long decimalValue = 0L;

            for (int i = 0; i < binValue.Length; i++)
            {
                digit = int.Parse(binValue[binValue.Length - 1 - i].ToString());
                int power = 1;

                for (int j = 0; j < i; j++)
                {
                    power *= 2;
                }

                decimalValue += digit * power;
            }

            return string.Format("{0:X}", decimalValue);
        }

        static void Main(string[] args)
        {
            string binValue = Console.ReadLine();

            Console.WriteLine(ConvertBinaryToHeaxadecimal(binValue));
        }
    }
}
