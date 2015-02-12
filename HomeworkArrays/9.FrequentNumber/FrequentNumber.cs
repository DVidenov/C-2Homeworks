using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter size of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int count = 0;
        int tempCount = 0;
        int elements = 0;

        Console.WriteLine("Enter the array: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        for (int i = 0; i < N; i++)
        {
            while (i < N)
            {
                if (array[i - 1] == array[i])
                {
                    tempCount++;
                    i++;
                }
                else
                {
                    break;
                }
            }
            if (count <= tempCount && elements < array[i - 1])
            {
                elements = array[i - 1];
                count = tempCount;
                tempCount = 0;
            }
            Console.WriteLine(elements);
        }
    }
}