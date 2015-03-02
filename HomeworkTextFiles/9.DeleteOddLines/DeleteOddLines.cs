//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
//http://stackoverflow.com/questions/15408867/deleting-alternate-rows-from-the-text-file-using-c-sharp
class DeleteOddLines
{
    static void Main()
    {
        StreamReader sr = new StreamReader(Console.ReadLine());
        string txtValues = sr.ReadToEnd();
        string[] txtValuesArray1 = Regex.Split(txtValues, "\r\n");

        ArrayList array = new ArrayList();
        foreach (string value in txtValuesArray1)
        {
            array.Add(value);
        }

        for (int i = 0; i < array.Count; i++)
        {
            if (array.Count % 2 != 0)
                array.RemoveAt(i + 2);
            else
                array.RemoveAt(i + 1);
        }
    }
}