using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class HexToBin
    {
        static string ConvertHexadecimalToBinary(string hexValue)
        {
            string binValue = null;

            for (int i = 0; i < hexValue.Length; i++)
            {
                string digit = null;

                switch (hexValue[i])
                {
                    case '0':
                        digit = "0000";
                        break;
                    case '1':
                        digit = "0001";
                        break;
                    case '2':
                        digit = "0010";
                        break;
                    case '3':
                        digit = "0011";
                        break;
                    case '4':
                        digit = "0100";
                        break;
                    case '5':
                        digit = "0101";
                        break;
                    case '6':
                        digit = "0110";
                        break;
                    case '7':
                        digit = "0111";
                        break;
                    case '8':
                        digit = "1000";
                        break;
                    case '9':
                        digit = "1001";
                        break;
                    case 'A':
                        digit = "1010";
                        break;
                    case 'B':
                        digit = "1011";
                        break;
                    case 'C':
                        digit = "1100";
                        break;
                    case 'D':
                        digit = "1101";
                        break;
                    case 'E':
                        digit = "1110";
                        break;
                    case 'F':
                        digit = "1111";
                        break;
                }

                binValue += digit;
            }

            return binValue;
        }

        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();

            Console.WriteLine(ConvertHexadecimalToBinary(hexValue));
        }
    }
}
