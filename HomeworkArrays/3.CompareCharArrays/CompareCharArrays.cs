using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter length for the first Array: ");
            int firstN = int.Parse(Console.ReadLine());
            char[] firstArray = new char[firstN];

            Console.WriteLine("Enter length for the second Array: ");
            int secondN = int.Parse(Console.ReadLine());
            char[] secondArray = new char[secondN];

            bool isEqual = true;
            if (firstN == secondN)
            {
                Console.WriteLine("Enter chars for the first Array: {0}", firstN);
                for (int i = 0; i < firstN; i++)
                {
                    Console.WriteLine("First Array is: {0}", i);
                    firstArray[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter chars for the second Array: {0}", secondN);
                for (int i = 0; i < secondN; i++)
                {
                    Console.WriteLine("Second Array is: {0}", i);
                    secondArray[i] = char.Parse(Console.ReadLine());
                }
                for (int i = 0; i < secondN; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        isEqual = false;
                    }
                }
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine("Equal={0}", isEqual);
        }
    }
}
