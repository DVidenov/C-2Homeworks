//Write a program that concatenates two text files into another text file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ConcatenateTextFiles
{
    static void Main()
    {
        Console.WriteLine("Enter file path:");
        string dirPath = Console.ReadLine();
        Console.WriteLine("Enter file Pattern:");
        string filePattern = Console.ReadLine();
        Console.WriteLine("Enter dest file:");
        string destFile = Console.ReadLine();
        string[] fileAry = Directory.GetFiles(dirPath, filePattern);

        Console.WriteLine("Total File Count : " + fileAry.Length);

        using (TextWriter tw = new StreamWriter(destFile, true))
        {
            foreach (string filePath in fileAry)
            {
                using (TextReader tr = new StreamReader(filePath))
                {
                    tw.WriteLine(tr.ReadToEnd());
                    tr.Close();
                    tr.Dispose();
                }
                Console.WriteLine("File Processed : " + filePath);
            }

            tw.Close();
            tw.Dispose();
        }
    }
}