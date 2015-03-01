//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
using System;
class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year: ");
        int y = int.Parse(Console.ReadLine());

        var leapYear = new DateTime(y);
        Console.WriteLine("Is {0} a leap year? {1}", y, DateTime.IsLeapYear(leapYear.Year));
    }
}