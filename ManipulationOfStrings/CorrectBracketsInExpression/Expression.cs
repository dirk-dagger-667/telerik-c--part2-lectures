using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBracketsInExpression
{
    class Expression
    {
        static void Main(string[] args)
        {
            string stringExpression = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < stringExpression.Length ; i++)
            {
                if (stringExpression[i] == '(')
                {
                    counter++;
                }
                if (stringExpression[i] == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    Console.WriteLine("The brackets are not as they should be");
                    return;
                }
            }
            Console.WriteLine("Everything is A-OK!!!!!");
        }
    }
}
