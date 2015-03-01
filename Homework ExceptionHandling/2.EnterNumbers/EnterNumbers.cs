//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EnterNumbers
{
    static void Main()
    {
        const int start = 1;
        const int end = 100;
        Console.WriteLine("Enter 10 numbers ,each number must be in range [1 - 100]:");
        int number = 0;
        int previousNumber = 0;
        for (int i = 0; i < 10; i++)
        {
            number = ReadNumber(start, end);
            previousNumber = number;
        }
    }
    private static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (start > number || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is out of the range [{0}..{1}]!\n", start, end);
        }
        return number;
    }
}