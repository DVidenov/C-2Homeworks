//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReplaceSubString
{
    static void Main()
    {
        Console.WriteLine("Enter path to the file you want to save the text: ");
        using (StreamWriter sw = new StreamWriter(Console.ReadLine()))
        {
            Console.WriteLine("Enter path to the file you want to edit: ");
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = line.Replace("start", "finish");
                    sw.WriteLine(line);
                }
            }
        }
    }
}