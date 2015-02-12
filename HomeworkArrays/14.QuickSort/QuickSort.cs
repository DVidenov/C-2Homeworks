//Problem 14. Quick sort
//Write a program that sorts an array of strings using the Quick sort algorithm.
﻿using System;
using System.Linq;
using System.Collections;

class QuickSort
{

    public static void quicksort(int[] input, int low, int high)
    {
        int pivotLoc = 0;
        if (low < high)
        {
            pivotLoc = partition(input, low, high);
            quicksort(input, low, pivotLoc - 1);
            quicksort(input, pivotLoc + 1, high);
        }
    }
    private static int partition(int[] input, int low, int high)
    {
        int pivot = input[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (input[j] <= pivot)
            {
                i++;
                swap(input, i, j);
            }
        }
        swap(input, i + 1, high);
        return i + 1;
    }
    private static void swap(int[] ar, int a, int b)
    {
        int temp;
        temp = ar[a];
        ar[a] = ar[b];
        ar[b] = temp;
    }
    static void Main()
    {
        int[] demoArr = new int[15];
        for (int i = 0; i < 15; i++)
        {
            if ((i & 1) == 0)
            {
                demoArr[i] = i;
            }
            else
            {
                demoArr[i] = -i;
            }
        }
        foreach (int number in demoArr)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine(" - The array is not sorted\nThe array is sorted: ");
        quicksort(demoArr, 0, 14);
        foreach (int number in demoArr)
        {
            Console.Write(number + " ");
        }
    }
}