//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()
using System;
class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int max = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
        Console.WriteLine("The largerst number is:{0}",max);
    }
    private static int GetMax(int first, int second)
    {
        if (first>second)
        {
            return first;
        }
        if (first<second)
        {
            return second;
        }
        else
        {
            return 1;
        }
    }
}