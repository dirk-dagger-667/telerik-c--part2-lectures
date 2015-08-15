using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLExtractor
{
    class Extractor
    {
        public static void ExtractHTML(string htmlDoc)
        {
            if (htmlDoc == null || htmlDoc == string.Empty)
            {
                throw new ArgumentNullException("the html doc is either null or empty");
            }
            else if (htmlDoc.Contains("\">") && htmlDoc.Contains("<a href=\"") && htmlDoc.Contains("</a>"))
            {
                Console.WriteLine("the html doc doesn't contain any URLs");
            }
            else
            {
                string replacedHTML = htmlDoc;
                replacedHTML = replacedHTML.Replace("\">", "]");
                replacedHTML = replacedHTML.Replace("<a href=\"", "[URL=");
                replacedHTML = replacedHTML.Replace("</a>", "[/URL]");
                Console.WriteLine(replacedHTML);
            }
        }

        static void Main(string[] args)
        {
            string htmlDocAsString = "<p>Please visit <a href=\"http://softuni.org\">our site</a> to choose a training course. Also visit <a href=\"http://forum.softuni.org\">our forum</a> to discuss the courses.</p>";

            ExtractHTML(htmlDocAsString);

        }
    }
}
