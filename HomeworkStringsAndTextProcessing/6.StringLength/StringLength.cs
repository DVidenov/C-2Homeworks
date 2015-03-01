//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
using System;
using System.Text;
class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter text with maximum 20 characters: ");
        string input = Console.ReadLine();

        StringBuilder output = new StringBuilder();

        while (input.Length > 20)
        {
            Console.WriteLine("The text must be maximum 20 characters: ");
            input = Console.ReadLine();
        }

        output.Append(input);
        
        for (int i = input.Length; i < 20; i++)
        {
            output.Append("*");
        }
        Console.WriteLine(output);
    }
}