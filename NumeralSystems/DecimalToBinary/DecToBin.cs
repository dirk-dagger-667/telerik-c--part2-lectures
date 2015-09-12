using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their binary representation.


namespace DecimalToBinary
{
    class DecToBin
    {
        static string ConvertDecimalToBinary(int decimalValue)
        {
            string binaryNumber = null;
            int remainder = 0;
            int devided = decimalValue;

            while (devided > 0)
            {
                remainder = devided % 2;
                devided = decimalValue / 2;
                decimalValue = devided;
                binaryNumber += remainder;
            }

            char[] reverse = binaryNumber.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        static void Main(string[] args)
        {
            int decimalValue = int.Parse(Console.ReadLine());

            Console.WriteLine(ConvertDecimalToBinary(decimalValue));
        }
    }
}
