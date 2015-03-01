//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number to be converted to biney number: ");
        string binaryVal = string.Empty;
        string strInput = Console.ReadLine();
        foreach (char ch in strInput)
        {
            binaryVal += Convert.ToString(Convert.ToInt32(ch.ToString(), 16), 2);
        }
        Console.WriteLine(binaryVal);
    }
}