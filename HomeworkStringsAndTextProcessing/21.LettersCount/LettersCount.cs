//Write a program that reads a string from the console and prints all different
//letters in the string along with information how many times each letter is found.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LettersCount
{
    //http://stackoverflow.com/questions/5102870/displaying-characters-and-how-many-times-they-appear
    static void Main()
    {
        Console.WriteLine("Enter your text here: ");
        string s =Console.ReadLine();
        var occurances = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (occurances.ContainsKey(c))
                occurances[c] = occurances[c] + 1;
            else
                occurances[c] = 1;
        }
        foreach (var entry in occurances)
        {
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
        }
    }
}