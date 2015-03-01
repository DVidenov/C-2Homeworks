//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter text with forbidden words(PHP, CLR, Microsoft): ");
        string input = Console.ReadLine();
        input = input.Replace("PHP", "***");
        input = input.Replace("CLR", "***");
        input = input.Replace("Microsoft", "*********");
        Console.WriteLine(input);
    }
}