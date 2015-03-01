//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReadFileContents
{
    //http://www.dotnetperls.com/file-readalltext
    static void Main()
    {
        Console.WriteLine("Please enter the location the name and the type of the file: ");//example-"F:\\TXT.txt"
        try
        {
            string text = File.ReadAllText(Console.ReadLine());

            Console.WriteLine("--- Contents of file.txt: ---");
            Console.WriteLine(text);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is a problem with the access to the file.");
            Console.WriteLine("This problem could appear if you enter a path, without the file type(.txt).Try again.");
            Main();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Wrong path to the fileplease try again.");
            Main();
        }
    }
}