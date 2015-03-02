//Write a program that compares two text files line by line and prints the number
//of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
//http://stackoverflow.com/questions/14370070/compare-two-text-files-line-by-line
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine("Enter the directory and the file name and type of the first file: ");
        string[] linesOne = File.ReadAllLines(Console.ReadLine());
        Console.WriteLine("Enter the directory and the file name and type of the second file: ");
        string[] linesTwo = File.ReadAllLines(Console.ReadLine());

        int maxLength = Math.Max(linesOne.Length, linesTwo.Length);
        int minLength = Math.Min(linesOne.Length, linesTwo.Length);

        for (int line = 0; line < maxLength; line++)
        {
            if (line < minLength)
            {
                if (linesOne[line].Equals(linesTwo[line]))
                {
                    Console.WriteLine("At line {0} : lines from both the file are same.", line);
                }
                else
                {
                    Console.WriteLine("At line {0} : lines are not same.", line);
                }
            }
            else
            {
                Console.WriteLine("Line {0} : doesnt exits in {1} file.", line,
                                                linesOne.Length == minLength ? "first" : "second");
            }
        }
    }
}