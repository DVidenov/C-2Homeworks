//You are given a text. Write a program that changes the text in all regions surrounded 
//by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
using System;
using System.Text;
class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string input = Console.ReadLine();
        var result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 8 && input.Substring(i, 8) == "<upcase>")
            {
                input = input.Remove(i, 8);
                while (i < input.Length - 9 && input.Substring(i, 9) != "</upcase>")
                {
                    result.Append(Char.ToUpper(input[i]));
                    i++;
                }
                input = input.Remove(i, 9);
            }
            result.Append(input[i]);
        }
        Console.WriteLine(result.ToString());
    }
}