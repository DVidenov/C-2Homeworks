//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Collections.Generic;
using System.Linq;
class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Please, enter array of numbers separated by space");
        string text = Console.ReadLine();

        string[] elements = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Please, enter each element of array between 0 and {0}", elements.Length - 1);
        int givenIndex = int.Parse(Console.ReadLine());

        int[] myArray = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            myArray[i] = int.Parse(elements[i]);
        }

        Console.WriteLine("Maximal element in a portion of array starting form given index {0}  = {1}", givenIndex, MaximalElement(givenIndex, myArray));
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", AscendingArray(myArray)));
        Console.WriteLine(string.Join(" ", DescendingArray(myArray)));
    }
    static int MaximalElement(int indexInArray, int[] array)
    {
        int maxElement = 0;

        for (int i = indexInArray; i < array.Length; i++)
        {
            if (maxElement < array[i])
            {
                maxElement = array[i];
            }
        }
        return maxElement;
    }

    static int[] DescendingArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int indexMax = Array.IndexOf(array, MaximalElement(i, array), i);
            int temp = array[indexMax];
            array[indexMax] = array[i];
            array[i] = temp;
        }
        return array;
    }
    static int[] AscendingArray(int[] array)
    {
        Array.Reverse(DescendingArray(array));
        return array;
    }

}