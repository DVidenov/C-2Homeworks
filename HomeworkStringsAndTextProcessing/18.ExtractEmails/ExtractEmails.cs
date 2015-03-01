﻿//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//http://stackoverflow.com/questions/21348474/extract-email-adresses-from-text-using-regex-c-sharp
class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Enter text here: ");
        string text =Console.ReadLine();

        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}