//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
class DownloadFile
{
    //http://stackoverflow.com/questions/307688/how-to-download-a-file-from-a-url-in-c
    static void Main()
    {
        try
        {
            WebClient webClient = new WebClient();
            Console.WriteLine("Enter the URL address after that the directory to save the file: ");
            webClient.DownloadFile(Console.ReadLine(), Console.ReadLine());
        }
        catch (WebException ex)
        {
            Console.Write(ex.Message);
            if (ex.InnerException != null)
                Console.WriteLine(" " + ex.InnerException.Message);
            else
                Console.WriteLine();
        }
    }
}