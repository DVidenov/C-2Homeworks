//Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.
//https://msdn.microsoft.com/en-us/library/system.string.format(v=vs.110).aspx

using System;
using System.Threading;
using System.Globalization;

class FormatNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("{0,15:F2}", number));
        Console.WriteLine(String.Format("{0,15:X}", number));
        Console.WriteLine(String.Format("{0,15:P2}", number));
        Console.WriteLine(String.Format("{0,15:E}", number));
    }
}