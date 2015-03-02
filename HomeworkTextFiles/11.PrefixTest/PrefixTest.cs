//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class PrefixTest
{
    static void Main()
    {
        Console.WriteLine("Enter path to the file you want to save the text: ");
        using (StreamWriter sw = new StreamWriter(Console.ReadLine()))
        {
            Console.WriteLine("Enter path to the file you want to edit: ");
            using (StreamReader sr = new StreamReader(Console.ReadLine()))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                    sw.WriteLine(line);
                }
            }
        }
    }
}