//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
using System;
class SayHello
{
    static void Main()
    {
        Console.WriteLine("Please enter your name: ");
        PrintingName();
    }

    private static void PrintingName()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}", name);
    }
}