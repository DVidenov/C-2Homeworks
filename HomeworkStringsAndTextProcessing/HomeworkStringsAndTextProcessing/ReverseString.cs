//Write a program that reads a string, reverses it and prints the result at the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        Console.WriteLine(reverse);
    }
}