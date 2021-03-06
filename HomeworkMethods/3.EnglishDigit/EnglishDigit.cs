﻿//Write a method that returns the last digit of given integer as an English word.
using System;
using System.Collections.Generic;
using System.Linq;
class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigitAsWord(number));
    }
    private static string LastDigitAsWord(int number)
    {
        int digit = number % 10;
        string result = string.Empty;
        switch (digit)
        {
            case 1:
                return result = "one"; break;
            case 2:
                return result = "two"; break;
            case 3:
                return result = "three"; break;
            case 4:
                return result = "four"; break;
            case 5:
                return result = "five"; break;
            case 6:
                return result = "six"; break;
            case 7:
                return result = "seven"; break;
            case 8:
                return result = "eight"; break;
            case 9:
                return result = "nine"; break;
            case 0:
                return result = "zero"; break; 
        }
        return result;
    }
}