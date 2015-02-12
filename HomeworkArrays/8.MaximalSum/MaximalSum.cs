//Write a program that finds the sequence of maximal sum in given array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int start = 0;
        int end = 0;
        int temp = 0;
        int maxSum = 0;
        int sum = 0;
        int minValue = 0;

        Console.WriteLine("The sequence is: ");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            sum += array[i];
            if (sum > maxSum)
            {
                maxSum = sum;
                end = i;
                start = temp;
            }
            if (sum <= 0)
            {
                sum = 0;
                temp = i + 1;
            }
        }
        for (int i = start; i <= end; i++)
        {
            Console.Write(array[i]+(i!=end ?", ":""));
        }
        Console.WriteLine();
    }
}