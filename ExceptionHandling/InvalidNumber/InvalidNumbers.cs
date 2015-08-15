using System;

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