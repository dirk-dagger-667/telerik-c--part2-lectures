using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


namespace BinRepresOf16BitInt
{
    class Int16Int
    {
        static string BinaryRepresentationOfShort(short shortValue)
        {
            string binaryRepresentation = null;
            short remainder = 0;
            int devided = shortValue;


            if(shortValue >= 0)
            {
                for (int i = 0; i < 15; i++)
                {
                    remainder = (short)(shortValue % 2);
                    devided = (short)(shortValue / 2);
                    shortValue = (short)devided;
                    binaryRepresentation += remainder;
                }
                binaryRepresentation += "0";
            }

            else
            {
                short decimalValue = (short)(65536 - shortValue);
                devided = decimalValue;

                for (int i = 0; i < 15; i++)
                {
                    remainder = (short)(decimalValue % 2);
                    devided = (short)(decimalValue / 2);
                    decimalValue = (short)devided;
                    binaryRepresentation += remainder;
                }

                binaryRepresentation += "1";
            }

            char[] reverseString = binaryRepresentation.ToArray();
            Array.Reverse(reverseString);

            return new string(reverseString);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the short number : ");
            short shortNumber = short.Parse(Console.ReadLine());
            Console.WriteLine("The binary reprisentation is : {0} ", BinaryRepresentationOfShort(shortNumber));

        }
    }
}
