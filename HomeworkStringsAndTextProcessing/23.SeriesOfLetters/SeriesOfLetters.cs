//Write a program that reads a string from the console and replaces all 
//series of consecutive identical letters with a single one.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SeriesOfLetters
//http://www.dotnetperls.com/duplicate-chars
{
    static void Main()
    {
        string text = RemoveDuplicateChars(Console.ReadLine());

        Console.WriteLine(text);
    }

    static string RemoveDuplicateChars(string key)
    {
        // --- Removes duplicate chars using string concats. ---
        // Store encountered letters in this string.
        string table = "";

        // Store the result in this string.
        string result = "";

        // Loop over each character.
        foreach (char value in key)
        {
            // See if character is in the table.
            if (table.IndexOf(value) == -1)
            {
                // Append to the table and the result.
                table += value;
                result += value;
            }
        }
        return result;
    }
}