//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
class BinaryShort
{

    static void Main()
    {
        Console.Write("Please, enter a 16-bit signed integer (short): ");
        short number = short.Parse(Console.ReadLine());
        if (number <= 32767)
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("Enter lower number: ");
        }
    }
}