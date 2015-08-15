using System;
using System.Net;

class DownloadForTheNEt
{
    static void Main()
    {
        Console.WriteLine("This program downloads a file from internet\n" +
            "by given URL from the user.");
        Console.Write("Please enter URL address: ");
        string URL = Console.ReadLine();
        Console.Write("Please enter file name: ");
        string file = Console.ReadLine();
        string fullAddress = URL + "/" + file;
        WebClient webClient = new WebClient();
        try
        {
            webClient.DownloadFile(fullAddress, file);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address can not be null");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid address or empty file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method does not support simultaneous downloads.");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}
