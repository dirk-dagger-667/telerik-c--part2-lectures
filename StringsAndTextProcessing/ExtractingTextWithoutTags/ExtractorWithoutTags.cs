using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingTextWithoutTags
{
    class ExtractorWithoutTags
    {
        public static void ExtractingWOTags(string textWithTags)
        {
            int startingIndex = 0;
            int endingIndex = 0;
            StringBuilder textWithoutTags = new StringBuilder();

            while (textWithTags.IndexOf('>', startingIndex) != -1)
            {
                startingIndex = textWithTags.IndexOf('>', startingIndex) + 1;
                endingIndex = textWithTags.IndexOf('<', startingIndex);

                if (endingIndex == -1)
                {
                    break;
                }
                else
                {
                    textWithoutTags.Append(textWithTags.Substring(startingIndex, endingIndex - startingIndex));
                    textWithoutTags.Append(" ");
                }
            }

            Console.WriteLine(textWithoutTags.ToString());
        }

        static void Main(string[] args)
        {
            string textWithTags = "<html><head><title>News</title></head><body><p><a href=\"http://softuni.org\">Software University</a>aims to provide free real-world practical training for young people who want to turn into skillful software engineers.</p></body></html>";

            ExtractingWOTags(textWithTags);
        }
    }
}
