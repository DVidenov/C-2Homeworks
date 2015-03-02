//Write a program that extracts from given XML file all the text without the tags.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
class ExtractTextFromXML
{
    //http://stackoverflow.com/questions/9847189/write-extracted-xml-elements-to-xml-without-additional-tags
    static void Main()
    {
        Console.WriteLine("Enter path to the file you want to save the text: ");
        XElement rootElement = XElement.Load(Console.ReadLine());
        Console.WriteLine("Enter path to the file you want to edit: ");
        FileStream fs = new FileStream(Console.ReadLine(), FileMode.Append);

        Console.WriteLine(fs);

        IEnumerable<XElement> elements = rootElement.Descendants("Extract1");
        foreach (XElement item in elements)
        {
            Console.WriteLine(item);
            item.Save(fs);
        }


        IEnumerable<XElement> elements2 = rootElement.Descendants("Extract2");
        foreach (XElement item in elements2)
        {
            Console.WriteLine(item);
            item.Save(fs);

        }
        fs.Close();
    }
}