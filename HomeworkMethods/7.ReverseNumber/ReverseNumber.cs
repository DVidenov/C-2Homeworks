//Write a method that reverses the digits of given decimal number.
using System;
class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter your number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("The reversed number is: "+ConvertDecimal(number));

    }
    static decimal ConvertDecimal(decimal number)
    {
        string text = Convert.ToString(number);
        char[] toConvert = text.ToCharArray();
        Array.Reverse(toConvert);
        string output = new string(toConvert);
        decimal result = decimal.Parse(output);
        return result;
    }
}