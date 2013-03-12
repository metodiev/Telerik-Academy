using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> 
//Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>

class ExtractXMLFile
{
    static void Main()
    {
        string arr = null;

        using (StreamReader reader = new StreamReader("XML.txt"))
        {
            string str = reader.ReadToEnd();
            arr = Regex.Replace(str, "<[^>]*>", "\n");
            string pattern = "[\n]+";
            arr = Regex.Replace(arr, pattern, "\n");
            Console.WriteLine(arr);
        } 
        
    }
}

