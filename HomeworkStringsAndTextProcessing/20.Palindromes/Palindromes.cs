﻿//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Palindromes
{
    //http://stackoverflow.com/questions/13957647/detect-word-palindrome-in-a-paragraph-using-c-sharp
    static void Main()
    {
        int i = 0;
        Console.WriteLine("Enter a String");
        string s = Console.ReadLine();
        string words = s.ToLower();
        string[] hasil = words.Split(' ');
        foreach (string temp in hasil)
        {
            string str = string.Empty;
            int x = temp.Length;

            for (int y = x - 1; y >= 0; y--)
            {
                str = str + temp[y];
            }

            int count = 0;
            if (str == temp)
            {
                count++;
                Console.WriteLine(temp + " is palindrome = " + count);
            }
            i++;
        }

    }
}