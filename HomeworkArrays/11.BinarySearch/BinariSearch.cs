using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BinariSearch
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        Console.WriteLine("Enter number for search: ");
        int S = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers for the array: ");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int start = 0;
        int end = array.Length;
        int center = (start + end) / 2;

        int pivot = S;
        while (S > 0)
        {
            while (S < array[center])
            {
                end = center;
                center = (end + start) / 2;
                if (pivot == center)
                {
                    Console.WriteLine("The index is:{0}", array[center]);
                    break;
                }
            }
            while (S > array[center])
            {
                start = center;
                center = (end + start) / 2;
                if (pivot == center)
                {
                    Console.WriteLine("The index is:{0}", array[center]);
                    break;
                }
            }
        }
    }
}