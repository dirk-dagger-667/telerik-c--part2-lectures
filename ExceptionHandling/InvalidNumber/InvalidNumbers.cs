using System;

//Write a program that takes a positive integer from the console and prints the square root of this integer. If the input is negative or invalid print "Invalid Number" in the console. In all cases print "Good Bye".

class InvalidSqrtInput
{
    public static int SquereRoot(string number)
    {
        {
            int validatedNumber;
            bool validNumber = int.TryParse(number, out validatedNumber);

            if (validNumber == true)
            {
                if (validatedNumber < 0)
                {
                    Console.WriteLine("Invalid Number");
                    return 0;
                }
                else
                {
                    return validatedNumber;
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
                return 0;
            }
        }
    }

    static void Main()
    {
        try
        {
            string stringNumber = Console.ReadLine();
            int sqrtOfNumber = SquereRoot(stringNumber);

            Console.WriteLine(sqrtOfNumber);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("InvalidNumber");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}