﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first integer: ");
        int firstN = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstN];

        Console.WriteLine("Enter the length of the second integer: ");
        int secondN = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondN];
        bool isEqual = true;

        if (firstN == secondN)
        {
            Console.WriteLine("Enter numbers for the first Array: {0}", firstArray);
            for (int i = 0; i < firstN; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter numbers for the second Array: {0}", secondArray);
            for (int i = 0; i < secondN; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < firstN; i++)
            {
                if (firstArray != secondArray)
                {
                    isEqual = false;
                    break;
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