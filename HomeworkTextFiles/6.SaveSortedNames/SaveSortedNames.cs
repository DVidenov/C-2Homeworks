//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6.SaveSortedNames;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        Console.WriteLine("Enter the file directory and name from which you want to read from:");
        StreamReader reader = new StreamReader(Console.ReadLine(), Encoding.ASCII);
        Console.WriteLine("Enter the file directory and name that you want copy to: ");
        StreamWriter writer = new StreamWriter(Console.ReadLine(), true);

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                List<string> Names = new List<string>();
                Names.Add(line);
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Names.Add(line);
                }
                Console.WriteLine("The words from the file:");
                foreach (string name in Names)
                {
                    Console.Write(name + " ");
                }
                Console.WriteLine();
                Names.Sort();
                Console.WriteLine("The words will not be sorted in sortred.txt:");
                foreach (string name in Names)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}