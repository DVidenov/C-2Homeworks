//Write a program to check if in a given expression the brackets are put correctly.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter your expression: ");
        Console.WriteLine("The expression is: {0}", CheckIfCorrectExpr());

    }

    public static bool CheckIfCorrectExpr()
    {
        string str = Console.ReadLine();
        if (str.IndexOf('(') > str.IndexOf(')'))
        {
            return false;
        }
        return true;
    }
}