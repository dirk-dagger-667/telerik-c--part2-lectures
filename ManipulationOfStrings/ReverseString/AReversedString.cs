﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class AReversedString
    {
        static void ReverseStrings()
        {
            
                Console.WriteLine("Enter the string you want to reverse");
                string reversable = Console.ReadLine();
                StringBuilder reversed = new StringBuilder();

                for (int i = reversable.Length - 1; i >= 0 ; i--)
                {
                    reversed.Append(reversable[i]);
                }

                Console.WriteLine(reversed.ToString());
        }

        static void Main(string[] args)
        {
            ReverseStrings();
        }
    }
}
