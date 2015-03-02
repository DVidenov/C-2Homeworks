//Modify the solution of the previous problem to replace only whole words (not strings).
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ReplaceWholeWord
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
                    line = Regex.Replace(line, @"\bstart\b", "finish");
                    sw.WriteLine(line);
                }
            }
        }
    }
}