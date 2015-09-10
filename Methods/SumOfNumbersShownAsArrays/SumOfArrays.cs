using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.


namespace SumOfNumbersShownAsArrays
{
    class SumOfArrays
    {
        static int[] DecimalNumberToIntArray(string inputNumber)
        {
            int[] arrayOfDigits = new int[inputNumber.Length];

            for (int i = 0; i < inputNumber.Length; i++)
            {
                arrayOfDigits[i] = inputNumber[inputNumber.Length - 1 - i] - '0';
            }

            return arrayOfDigits;
        }

        static int[] SumOfDigits(int[] arrayOne, int[] arrayTwo)
        {
            if (arrayOne.Length > arrayTwo.Length)
			{
                int[] remainder = new int[arrayOne.Length + 1];
                int[] resultingArray = new int[arrayOne.Length + 1];

                for (int i = 0; i <arrayTwo.Length; i++)
                {
                    if (arrayOne[i] + arrayTwo[i] > 10)
                    {
                        remainder[i + 1] = 1;
                    }

                    else
                    {
                        remainder[i + 1] = 0;
                    }
                    resultingArray[i] = (arrayOne[i] + arrayTwo[i])%10 + remainder[i];
                }

                for (int i = arrayOne.Length - arrayTwo.Length; i < resultingArray.Length; i++)
                {
                    resultingArray[i] = arrayOne[i] + remainder[i];
                }

                return resultingArray;
            }

            else if(arrayOne.Length < arrayTwo.Length)
            {
                int[] remainder = new int[arrayTwo.Length + 1];
                int[] resultingArray = new int[arrayTwo.Length + 1];

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] + arrayTwo[i] > 10)
                    {
                        remainder[i + 1] = 1;
                    }

                    else
                    {
                        remainder[i + 1] = 0;
                    }
                    resultingArray[i] = (arrayOne[i] + arrayTwo[i]) % 10 + remainder[i];
                }

                for (int i = arrayTwo.Length - arrayOne.Length; i < resultingArray.Length; i++)
                {
                    resultingArray[i] = arrayTwo[i] + remainder[i];
                }

                return resultingArray;
            }

            else
            {
                int[] remainder = new int[arrayTwo.Length + 1];
                int[] resultingArray = new int[arrayTwo.Length + 1];

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] + arrayTwo[i] > 10)
                    {
                        remainder[i + 1] = 1;
                    }

                    else
                    {
                        remainder[i + 1] = 0;
                    }
                    resultingArray[i] = (arrayOne[i] + arrayTwo[i]) % 10 + remainder[i];
                }

                resultingArray[resultingArray.Length - 1] = remainder[resultingArray.Length - 1];

                return resultingArray;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number : ");
            string inputNumberOne = Console.ReadLine();
            Console.WriteLine("Enter the second Number : ");
            string inputNumberTwo = Console.ReadLine();

            int[] firstArray = DecimalNumberToIntArray(inputNumberOne);
            int[] secondArray = DecimalNumberToIntArray(inputNumberTwo);
            int[] result = SumOfDigits(firstArray, secondArray);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[result.Length - 1 - i]);
            }
        }
    }
}
