//Write a program that finds in given array of integers a sequence of given sum S (if present).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the how numbers the sum will be: ");
        int S = int.Parse(Console.ReadLine());
        Console.WriteLine("Array numbers: ");

        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        bool exist = false;

        for (int i = 0; i < N && !exist; i++)
        {
            int sum = array[i];
            string sequence = array[i] + ",";
            for (int j = i + 1; j < N && !exist; j++)
            {
                sum += array[j];
                sequence += array[j] + ",";
                if (sum == S)
                {
                    Console.WriteLine(sequence.TrimEnd(','));
                    exist = true;
                }
            }
        }
        if (!exist)
        {
            Console.WriteLine("doesn't exist");
        }

    }
}