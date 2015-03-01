//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class OrderWords
{
    //http://www.dotnetperls.com/sort
    static void Main()
    {
        List<string> l = new List<string>();
	    l.Add(Console.ReadLine());
        l.Add(Console.ReadLine());
        l.Add(Console.ReadLine());
        l.Add(Console.ReadLine());
        l.Add(Console.ReadLine());
        l.Add(Console.ReadLine());
	{
	};
        l.Sort();
        foreach (string s in l)
        {
            Console.WriteLine(s);
        }
    }
}