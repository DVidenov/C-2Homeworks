using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int counter = 0;
        bool isBool = true;
        int[] countArray = new int[counter];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            for (int j = 1; j < n; j++)
            {
                if (array[i] % 2 != 0 && array[i] % 3 != 0 && array[i] % 4 != 0 && array[i] % 5 != 0 && array[i] % 6 != 0 && array[i] % 7 != 0)
                {
                    counter += array[i];
                    Console.WriteLine(isBool);
                    counter++;
                }
                else if (array[j]==3&&array[j]==5&&array[j]==7)
                {
                    Console.WriteLine(isBool);
                }
                else
                {
                    Console.WriteLine("False");
                }
                break;
            }
        }
    }
}