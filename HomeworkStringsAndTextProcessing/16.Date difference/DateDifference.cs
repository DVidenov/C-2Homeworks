//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
using System;
using System.Globalization;
class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date in type [dd.MM.yyyy]: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date in type [dd.MM.yyyy]: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("The difference is= {0} days", (secondDate - firstDate).Days);

    }
}