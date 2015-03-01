//Write a program that reverses the words in given sentence.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReverseSentence
{
    //http://www.dotnetperls.com/reverse-words
    static void Main()
    {
        string input = Console.ReadLine();

        string rev1 = WordTools.ReverseWords(input);
        Console.WriteLine(rev1);

    }

    static class WordTools
    {
        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}