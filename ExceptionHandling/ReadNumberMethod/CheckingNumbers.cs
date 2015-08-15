using System;


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
