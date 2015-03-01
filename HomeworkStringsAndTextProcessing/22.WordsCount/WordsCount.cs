//Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.
using System;
using System.Text.RegularExpressions;

class WordsCount
{
    //http://www.dotnetperls.com/word-count
    static void Main()
    {
        Console.Write("Enter your text here: ");
        string text = Console.ReadLine();
        Console.WriteLine("The number of used words is: " + WordCounting.CountWords1(text));
    }
}

/// <summary>
/// Contains methods for counting words.
/// </summary>
public static class WordCounting
{
    /// <summary>
    /// Count words with Regex.
    /// </summary>
    public static int CountWords1(string s)
    {
        MatchCollection collection = Regex.Matches(s, @"[\S]+");
        return collection.Count;
    }
}