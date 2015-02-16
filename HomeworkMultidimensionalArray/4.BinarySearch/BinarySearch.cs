//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
using System;
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Please how many number the array will be: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Insert the number K for searching");
        int k = int.Parse(Console.ReadLine());
        int index = 0;
        Console.WriteLine("Enter the numbers for the integer");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Console.WriteLine("The sorted array:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        if (array[0] > k)
        {
            Console.WriteLine("There is no number wich is less or equal to {0}", k);
        }
        for (int i = k; i >= 0; i--)
        {
            if (Array.BinarySearch(array, i) >= 0)
            {
                Console.WriteLine("The largest number in the array which is equal or less than {0} is {1}.", k, i);
                return;
            }
        }
    }
}