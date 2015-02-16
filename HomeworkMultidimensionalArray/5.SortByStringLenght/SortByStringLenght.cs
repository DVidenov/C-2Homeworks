//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;
class SortByStringLenght
{
    static void Main()
    {
        Console.WriteLine("Please enter how many numbers the array will be: ");
        int numbers = int.Parse(Console.ReadLine());
        string[] array = new string[numbers];

        Console.WriteLine("Enter the numbers");
        for (int i = 0; i < numbers; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = Console.ReadLine();
        }
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine("The sorted array by the lenght of it's elements is: ");
        Console.WriteLine(string.Join(",", array));
    }
}