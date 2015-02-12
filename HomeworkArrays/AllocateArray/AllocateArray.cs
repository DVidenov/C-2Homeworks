//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
using System;
class AllocateArray
{
    static void Main()
    {
        int[] N = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        for (int i = 0; i <= N.Length; i++)
        {
            int c = i * 5;
            Console.WriteLine("{0}-->{1}", i, c);
        }
    }
}