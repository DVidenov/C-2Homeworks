//Write a program that parses an URL address given in the format: [protocol]:
//[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ParseURL
{
    static void Main()
    {
               //Pomognah si za koda ot kolega ot foruma***
        //http://telerikacademy.com/Courses/Courses/Details/212
        Console.Write("Enter URL: ");
        string input = Console.ReadLine();

        StringBuilder protocol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resource = new StringBuilder();

        int i = 0;

        while (input[i] != ':')
        {
            protocol.Append(input[i]);
            i++;
        }
        i += 3;
        while (input[i] != '/')
        {
            server.Append(input[i]);
            i++;
        }
        while (i < input.Length)
        {
            resource.Append(input[i]);
            i++;
        }

        Console.WriteLine("Protocol = {0}\nServer = {1}\nResource = 2", protocol, server, resource);
    }
}