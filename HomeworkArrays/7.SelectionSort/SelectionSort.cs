//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm:
//Find the smallest element, move it at the first position, find the smallest from the rest,
//move it at the second position, etc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class SelectionSortt
{
    static void Main()
    {
        Console.WriteLine("Enter how long the array will be: ");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Array before sorting: ");
        Console.WriteLine(string.Join(" ", arr));

        arr = SelectionSort(arr);

        Console.Write("Array after sorting: ");
        Console.WriteLine(string.Join(" ", arr));

    }
    private static int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int indexer = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[indexer])
                {
                    indexer = j;
                }
            }
            int swap = arr[i];
            arr[i] = arr[indexer];
            arr[indexer] = swap;
        }
        return arr;
    }
}