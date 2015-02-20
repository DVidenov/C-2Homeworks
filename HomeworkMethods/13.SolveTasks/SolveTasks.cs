//Problem 13. Solve tasks
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Threading;
using System.Globalization;

class SolveTasks
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        //Provide a simple text-based menu for the user to choose which task to solve.
        Console.WriteLine("Please choose a task:");
        Console.WriteLine("1 --> Reverses the digits of a number ");
        Console.WriteLine("2 --> Calculates the average of a sequence of integers");
        Console.WriteLine("3 --> Solves a linear equation a * x + b = 0");

        string digit = Console.ReadLine();

        int number;
        if (int.TryParse(digit, out number))

            if (number == 1)
            {
                //Reverses the digits of a number
                Console.WriteLine("Decimal maxValue");
                Console.WriteLine(Decimal.MaxValue);
                Console.WriteLine("Please,enter a number less than Decimal maxValue and over Zero(0)");
                decimal numberDecimal = decimal.Parse(Console.ReadLine());

                //The decimal number should be non-negative
                if (numberDecimal < 0 || numberDecimal > Decimal.MaxValue)
                {
                    Console.WriteLine("The decimal number should be non-negative");
                    return;
                }
                Console.WriteLine();
                Console.WriteLine(ConvertDecimal(numberDecimal));

            }
            else if (number == 2)
            {
                //Calculates the average of a sequence of integers
                Console.WriteLine("Please, enter array of numbers separated by space");
                string text = Console.ReadLine();
                string[] elements = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //The sequence should not be empty                
                if (elements.Length == 0)
                {
                    Console.WriteLine("The sequence should not be empty");
                    return;
                }
                int[] myArray = new int[elements.Length];
                for (int i = 0; i < elements.Length; i++)
                {
                    myArray[i] = int.Parse(elements[i]);
                }
                Console.WriteLine("Average of the sequence = {0:F4}", CalculatesAverage(myArray));
            }
            else if (number == 3)
            {
                //Solves a linear equation a * x + b = 0
                Console.WriteLine("Please,enter variable a");
                decimal variableA = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please,enter variable b");
                decimal variableB = decimal.Parse(Console.ReadLine());
                //a should not be equal to 0
                if (variableA == 0)
                {
                    Console.WriteLine("a should not be equal to 0");
                    return;
                }
                Console.WriteLine("X = {0:F4}", SolvesLinear(variableA, variableB));
            }
            else
            {
                Console.WriteLine("Not a valid input");
            }
        else
        {
            Console.WriteLine("Not a valid input");
        }
    }


    //  Method Reverses the digits of a number
    static decimal ConvertDecimal(decimal number)
    {
        string text = Convert.ToString(number);
        char[] toConvert = text.ToCharArray();
        Array.Reverse(toConvert);
        decimal result = decimal.Parse(new string(toConvert));
        return result;
    }

    // Method Calculates the average of a sequence of integers
    static decimal CalculatesAverage(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        decimal average = Convert.ToDecimal(sum) / Convert.ToDecimal(array.Length);
        return average;
    }

    //Solves a linear equation a * x + b = 0
    static decimal SolvesLinear(decimal variableA, decimal variableB)
    {
        return (-variableB) / variableA;
    }
}