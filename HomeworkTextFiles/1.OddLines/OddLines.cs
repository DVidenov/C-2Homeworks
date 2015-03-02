﻿//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class OddLines
{
    static void Main()
    {
        Console.WriteLine("Enter directory, name and type of the file:");
        StreamReader reader = new StreamReader(Console.ReadLine(), Encoding.ASCII);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if ((lineNumber & 1) == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = reader.ReadLine();
            }

        }
    }
}
