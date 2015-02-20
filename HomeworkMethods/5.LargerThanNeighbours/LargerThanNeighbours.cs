//Write a method that checks if the element at given position in given array
//of integers is larger than its two neighbours (when such exist).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter how long will be the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        Console.WriteLine("Enter the numbers in the array: ");
        for (int i = 0; i < n; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter position for searching: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("The nuber at position {0} is larger than his neighbours:{1}", position, LargerThanNeigbours(array1, position));
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