//Write a program that extracts from a given text all sentences containing given word.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("Enter text here: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter to be searched for word");
        string word = Console.ReadLine();
        Console.WriteLine(Extraction(text, word));
    }
    private static string Extraction(string text, string givenWord)
    {
        string word = " " + givenWord + " ";
        StringBuilder output = new StringBuilder();
        string[] sentence = text.Split('.');
        foreach (var item in sentence)
        {
            if (item.IndexOf(word) > 0)
            {
                output.Append(item);
            }

        }
        return output.ToString();
    }
}