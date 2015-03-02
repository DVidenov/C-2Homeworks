//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LineNumbers
{
    //Zadachata e reshena s pomosht ot foruma
    static void Main()
    {
        Console.WriteLine("Enter the directori of the file: ");
        StreamReader reader = new StreamReader(Console.ReadLine(), Encoding.ASCII);
        Console.WriteLine("Enter the directory of the target file: ");
        StreamWriter writer = new StreamWriter(Console.ReadLine(), true);

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    counter++;
                    line = line.Insert(0, "Line " + counter.ToString() + ": ");
                    Console.WriteLine(line + "sucessfully stored into the target file ");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }

        }
    }
}