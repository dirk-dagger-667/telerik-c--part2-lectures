﻿using System;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//        The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

class UpperCase
{
    public static string UpperCaseInTags(string text, string tag)
    {
        string TagStart = "<" + tag + ">";
        string TagEnd = "</" + tag + ">";
        while (text.IndexOf(TagStart) != -1)
        {
            int PosStart = text.IndexOf(TagStart);
            int PosEnd = text.IndexOf(TagEnd);
            string temp = text.Substring(PosStart + TagStart.Length, PosEnd - PosStart - TagStart.Length);
            text = text.Replace(TagStart + temp + TagEnd, temp.ToUpper());
        }
        return text;
    }

    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string tag = "upcase";
        Console.WriteLine(UpperCaseInTags(text, tag));
    }
}
