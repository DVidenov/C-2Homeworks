//Write a program to convert binary numbers to their decimal representation.
using System;

class BinaryToDecimal
{
    static void main()
    {
        double sum = 0;
        int n = int.Parse(Console.ReadLine());
        int strin = n.ToString().Length;
        for (int i = 0; i < strin; i++)
        {
            int lastDigit = n % 10;
            sum = sum + lastDigit * (Math.Pow(2, i));
            n = n / 10;
        }
        Console.WriteLine(sum);
    }
}
