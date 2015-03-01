//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.
using System;
using System.Globalization;
using System.Threading;
class DayOfWeek
{
    static void Main()
    {
        DateTime now = DateTime.Today;
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(now.ToString("dddd"));
            return;
        } 
    }
}