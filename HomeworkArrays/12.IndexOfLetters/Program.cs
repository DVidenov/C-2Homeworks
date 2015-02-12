//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        char[] allLetterAlphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            allLetterAlphabet[i] = (char)(i + 65);
        }
        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < allLetterAlphabet.Length; j++)
            {
                if (word[i] == allLetterAlphabet[j])
                {
                    Console.WriteLine("Letter {0} is {1}. Index in array of all letters is {2}.", i, word[i], j);
                    break;
                }
            }
        }
    }
}