//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class RemoveWords
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter path to the file you want to save the text: ");
            using (StreamWriter sw = new StreamWriter(Console.ReadLine()))
            {
                Console.WriteLine("Enter path to the file you want to edit: ");
                using (StreamReader sr = new StreamReader(Console.ReadLine()))
                {
                    string line;
                    string regex = @"\b(" + String.Join("|", File.ReadAllLines("words.txt")) + @")\b";
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, regex, string.Empty);
                        sw.WriteLine(line);
                    }
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}