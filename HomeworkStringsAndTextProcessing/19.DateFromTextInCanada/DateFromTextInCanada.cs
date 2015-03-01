//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DateFromTextInCanada
{
    //https://msdn.microsoft.com/en-us/library/cc165448.aspx
    static void Main()
    {
        string date = Console.ReadLine();
        DateTime dt = Convert.ToDateTime(date);

        // Specify exactly how to interpret the string.
        IFormatProvider culture = new System.Globalization.CultureInfo("en-CA", true);

        // Alternate choice: If the string has been input by an end user, you might  
        // want to format it according to the current culture: 
        // IFormatProvider culture = System.Threading.Thread.CurrentThread.CurrentCulture;
        DateTime dt2 = DateTime.Parse(date, culture, System.Globalization.DateTimeStyles.AssumeLocal);
        Console.WriteLine("Year: {0}, Month: {1}, Day {2}", dt2.Year, dt2.Month, dt2.Day);
    }
}