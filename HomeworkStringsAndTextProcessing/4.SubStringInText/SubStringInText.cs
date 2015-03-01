//Write a program that finds how many times a sub-string is 
//contained in a given text (perform case insensitive search).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SubStringInText
{
    static void Main()
    {
        {
            Console.WriteLine("Enter text to seach in: ");
            string text = Console.ReadLine();
            Console.Write("Enter substring to search: ");
            string subString = Console.ReadLine();
            Console.WriteLine("{0} is contained in the text: {1} ({2} times)", subString, text.Trim(), CountSubstring(subString, text));
        }
    }

    static int CountSubstring(string subString, string text)
    {
        int index = -1;
        int counter = 0;
        while (true)
        {
            index = text.ToLower().IndexOf(subString, index + 1);

            if (index == -1)
            {
                break;
            }
            string txt = text.Substring(index);
            counter++;
        }
        return counter;
    }
}