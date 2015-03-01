//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("The square root of the number is: " + (Math.Sqrt(number)));
            Console.WriteLine();
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number, it is out of range! ");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number, it must be positiv! ");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number, the end of the number is wrong!");
        }
        finally
        {
            Console.WriteLine("\nGood bye");
        }
    }
}