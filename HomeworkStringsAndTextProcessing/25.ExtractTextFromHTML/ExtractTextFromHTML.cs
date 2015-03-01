//Write a program that extracts from given HTML file its title (if available), 
//and its body text without the HTML tags.
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class HtmlTagRemover
{
    //http://www.dotnetperls.com/paragraph-html
    static void Main()
    {
        // Read in an HTML file.
        string html = File.ReadAllText(Console.ReadLine());

        // Get the first paragraph.
        Console.Write(GetFirstParagraph(html));

        // End.
        Console.ReadLine();
    }

    /// <summary>
    /// Get first paragraph between P tags.
    /// </summary>
    static string GetFirstParagraph(string file)
    {
        Match m = Regex.Match(file, @"<p>\s*(.+?)\s*</p>");
        if (m.Success)
        {
            return m.Groups[1].Value;
        }
        else
        {
            return "";
        }
    }
}