using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyNumSysToAnyNumSys
{
    class UniversalConverter
    {
        static int ConvertAnyNumSysToDecimal(string anyValue, int baseOfNumberalSystem)
        {
            int digit = 0;
            int decimalValue = 0;

            for (int i = 0; i < anyValue.Length; i++)
            {
                if (anyValue[anyValue.Length - 1 - i] >= '0' && anyValue[anyValue.Length - 1 - i] <= '9')
                {
                    digit = int.Parse(anyValue[anyValue.Length - 1 - i].ToString());
                }

                else switch(anyValue[anyValue.Length - 1 - i])
                {
                    case 'A':
                        digit = 10;
                        break;
                    case 'B':
                        digit = 11;
                        break;
                    case 'C':
                        digit = 12;
                        break;
                    case 'D':
                        digit = 13;
                        break;
                    case 'E':
                        digit = 14;
                        break;
                    case 'F':
                        digit = 15;
                        break;
                }
                int power = 1;

                for (int j = 0; j < i; j++)
                {
                    power *= baseOfNumberalSystem;
                }

                decimalValue += digit * power;
            }

            return decimalValue;
        }

        static string DecimalToAnyOtherNumSys(int decimalValue ,int baseOfConvertedSystem)
        {
            string convertedNumber = null;
            int remains = 0;
            int devided = decimalValue;
            char character = '0';

            while (devided > 0)
            {
                remains = devided % baseOfConvertedSystem;
                devided = decimalValue / baseOfConvertedSystem;
                decimalValue = devided;

                switch (remains)
                {
                    case 0:
                        character = '0';
                        break;
                    case 1:
                        character = '1';
                        break;
                    case 2:
                        character = '2';
                        break;
                    case 3:
                        character = '3';
                        break;
                    case 4:
                        character = '4';
                        break;
                    case 5:
                        character = '5';
                        break;
                    case 6:
                        character = '6';
                        break;
                    case 7:
                        character = '7';
                        break;
                    case 8:
                        character = '8';
                        break;
                    case 9:
                        character = '9';
                        break;
                    case 10:
                        character = 'A';
                        break;
                    case 11:
                        character = 'B';
                        break;
                    case 12:
                        character = 'C';
                        break;
                    case 13:
                        character = 'D';
                        break;
                    case 14:
                        character = 'E';
                        break;
                    case 15:
                        character = 'F';
                        break;
                }

                convertedNumber += character;
            }

            return convertedNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of the of the system you want to convert : ");
            int baseOfNumSys = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the base of the system you want to convert to : ");
            int baseOfConverted = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number : ");
            string number = Console.ReadLine();

            Console.WriteLine(ConvertAnyNumSysToDecimal(number,baseOfNumSys));
            Console.WriteLine(DecimalToAnyOtherNumSys(ConvertAnyNumSysToDecimal(number,baseOfNumSys),baseOfConverted));
        }
    }
}
