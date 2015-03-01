//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
//of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Enter the cipher: ");
        string cipher = Console.ReadLine();

        string decode = StringEncoded(text, cipher);
        Console.WriteLine(decode);
    }

    private static string StringEncoded(string text, string cipher)
    {
        StringBuilder output = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            int j = i % cipher.Length;
            output.Append((char)(text[i] ^ cipher[j]));
        }
        return output.ToString();
    }
}