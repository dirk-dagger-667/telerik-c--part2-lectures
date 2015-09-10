using System;

//Write a method ReadNumber(int start, int end) that reads an integer from the console in the range [start…end]. In case the input integer is not valid or it is not in the required range throw appropriate exception. Using this method, write a program that takes 10 integers a1, a2, …, a10 such that 1 < a1 < … < a10 < 100.

class CheckingNumbers
{
    static int ReadNumber(int start, int end)
    {
        int n = 1;
        bool isNumber = int.TryParse(Console.ReadLine(), out n);

        if (isNumber == true)
        {
            if (n < start || n > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return n;
            }
        }
        else
        {
            throw new ArgumentException();
        }
    }
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        try
        {
            if (start < end)
            {
                while (counter <= 10)
                {
                    int integerNumber = ReadNumber(start, end);
                    int previousNumber = 0;

                    if (integerNumber > previousNumber)
                    {
                        counter++;
                    }

                    counter++;
                    previousNumber = integerNumber;
                }
            }
            else
            {
                Console.WriteLine("Start argument is bigger than end argument, and it SHOULDN'T BE!");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            counter--;
            Console.WriteLine("the number is out of the specified range");
        }
        catch(ArgumentNullException)
        {
            counter--;
            Console.WriteLine("argument is null");
        }
        catch(ArgumentException)
        {
            counter--;
            Console.WriteLine("");
        }
    }
}
