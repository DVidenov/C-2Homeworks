//Write a program that finds the maximal sequence of equal elements in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the Array elements separated by space");
        string givenNumbers = Console.ReadLine();
        string[] givenArray = givenNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int currentElementIndex = 0;
        int CurrentLength = 0;
        int MaxLength = 0;
        string BestElement = "0";

        for (int i = 1; i < givenArray.Length; i++)
        {
            if (givenArray[i] == givenArray[currentElementIndex])
            {
                CurrentLength++;
            }
            else
            {
                currentElementIndex = i;
                CurrentLength = 1;
            }
            if (CurrentLength >= MaxLength)
            {
                MaxLength = CurrentLength;
                BestElement = givenArray[i];
            }
        }
        for (int i = 0; i < MaxLength; i++)
        {
            Console.Write("{0} ", BestElement);
        }
        Console.WriteLine();
    }
}