//Write a program that replaces in a HTML document given as string 
//all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter HTML document");
        string textHTML = Console.ReadLine();
        string output = string.Empty;
        int counter = 0;
        while (textHTML.IndexOf("<a href=\"", counter) > 0)
        {
            output = textHTML.Replace("<a href=\"", "[URL=");
            counter++;
        }
        counter = 0;
        while (output.IndexOf("\">", counter) > 0)
        {
            output = output.Replace("\">", "]");
            counter++;
        }
        counter = 0;
        while (output.IndexOf("</a>", counter) > 0)
        {
            output = output.Replace("</a>", "[/URL]");
            counter++;
        }
        Console.WriteLine(output);
    }
}