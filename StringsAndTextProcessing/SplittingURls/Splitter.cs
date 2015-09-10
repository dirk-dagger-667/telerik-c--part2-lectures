using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL in following format:
//[protocol]://[server]/[resource]
//It should extract from the URL the protocol, server and resource parts. For example, when http://www.cnn.com/video is passed, the result is:
//[protocol]="http"
//[server]="www.cnn.com"
//[resource]="/video"

namespace SplittingURls
{
    class Splitter
    {
        const string firstDevider = "://";
        const string secondDevider = "/";

        public static void SplittingTheURLIn3(string inputURL)
        {
            int indexOfFirstDevider = inputURL.IndexOf(firstDevider);
            int indexOfSecondDevider = inputURL.IndexOf(secondDevider, indexOfFirstDevider + 3);

            if (inputURL == null || inputURL == String.Empty)
            {
                throw new ArgumentNullException(@"The URL's value is null or empty!s");   
            }
            else if (indexOfFirstDevider == -1)
            {
                throw new FormatException(@"Invalid format for the URL!");
            }
            else if (indexOfSecondDevider == -1)
            {
                throw new FormatException(@"Invalid format for the URL!");
            }
            else
            {
                string protocol = inputURL.Substring(0, inputURL.Length - (inputURL.Length - indexOfFirstDevider));
                string server = inputURL.Substring(indexOfFirstDevider + 3, inputURL.Length - (indexOfFirstDevider + 3) -
                    (inputURL.Length - indexOfSecondDevider));
                string resource = inputURL.Substring(indexOfSecondDevider + 1, inputURL.Length - indexOfSecondDevider);
                Console.WriteLine(protocol);
                Console.WriteLine(server);
                Console.WriteLine(resource);
            }
        }

        static void Main(string[] args)
        {
            string inputURL = "http://www.cnn.com/video";
            SplittingTheURLIn3(inputURL);
        }
    }
}
