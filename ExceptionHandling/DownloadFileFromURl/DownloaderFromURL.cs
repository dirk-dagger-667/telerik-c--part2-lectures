using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

namespace DownloadFileFromInternet
{
    class DownloadFileFromInternet
    {
        static void Main(string[] args)
        {
            WebClient wc = null;
            string errorMessage = null;
            string url = Console.ReadLine();

            try
            {
                wc = new WebClient();
                // Download a file from i-net to the current directory.
                wc.DownloadFile(url, @".\google.png");
                // Download a file from i-net to parent directory of parent directory.
                wc.DownloadFile(url, @"..\..\google.png");
            }
            catch (WebException we)
            {
                errorMessage = we.Message;
            }
            catch (NotSupportedException nse)
            {
                errorMessage = nse.Message;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            finally
            {
                if (errorMessage != null)
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }
    }
}

