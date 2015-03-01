//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", Convert.ToUInt16(input[i]));
        }
        Console.WriteLine();
    }
}