//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number to be converted to hexadecimal: ");
        string bin = Console.ReadLine();

        int rest = bin.Length % 4;
        if (rest != 0)
            bin = new string('0', 4 - rest) + bin;

        string output = "";

        for (int i = 0; i <= bin.Length - 4; i += 4)
        {
            output += string.Format("{0:X}", Convert.ToByte(bin.Substring(i, 4), 2));
        }
        Console.WriteLine(output);
    }
}