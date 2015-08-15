using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(-4,2).ToString());

            string[] arrayStrings = new string[13];
            arrayStrings[0] = "-4";
            arrayStrings[1] = "2";
            arrayStrings[0] = Math.Pow(double.Parse(arrayStrings[0]), double.Parse(arrayStrings[1])).ToString();
        }
    }
}
