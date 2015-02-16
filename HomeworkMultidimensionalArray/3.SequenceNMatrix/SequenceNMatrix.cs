//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
using System;
class SequenceNMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter the number of the rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of the columns: ");
        int cols = int.Parse(Console.ReadLine());
        int maxCounter = 0;
        int counter = 1;
        string longestSequence = "";


        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.WriteLine("matrix [{0},{1}]=", row, col);
                matrix[row, col] = (Console.ReadLine());
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == matrix[row, col + 1] || matrix[row, col] == matrix[row + 1, col] || matrix[row, col] == matrix[row + 1, col + 1])
                {
                    int maxSum = 0;
                    int sum = maxSum + 1;
                }
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 1; col < cols; col++)
            {
                if (matrix[row, col] == matrix[row, col - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter >= maxCounter)
                {
                    maxCounter = counter;
                    longestSequence = matrix[row, col];
                }
            }
            counter = 1;
        }
        counter = 1;

        for (int col = 0; col < cols; col++)
        {
            for (int row = 1; row < rows; row++)
            {
                if (matrix[row, col] == matrix[row - 1, col])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter >= maxCounter)
                {
                    maxCounter = counter;
                    longestSequence = matrix[row, col];
                }
            }
            counter = 1;
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                counter = 1;
                for (int i = row, j = col; i < (rows - 1) && (j < cols - 1); i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }

                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        longestSequence = matrix[i, j];
                    }
                }
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = cols - 1; col >= 0; col--)
            {
                counter = 1;
                for (int i = row, j = col; i < (rows - 1) && (j > 0); i++, j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        counter++;
                    }

                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        longestSequence = matrix[i, j];
                    }
                }
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        if (maxCounter > 1)
        {
            Console.Write(longestSequence);
            for (int i = 1; i < maxCounter; i++)
            {
                Console.Write("," + longestSequence);
            }
            Console.WriteLine();
        }
    }
}