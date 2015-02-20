//Write a method that returns the index of the first element in array that is larger than its neighbours,
//or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter how long will be the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the numbers in the array: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("First element larget than its neigbours is at index : {0} ",
                                                                    FirstLargeElement(arr));
    }
    static int FirstLargeElement(int[] array)
    {
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (LargerThanNeigbours(array, i))
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }
        return index;
    }
    static bool LargerThanNeigbours(int[] array, int index)
    {
        bool isLarger = false;
        if ((index - 1) >= 0 && (index + 1) < array.Length)
        {
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                isLarger = true;
            }
        }
        return isLarger;
    }
}