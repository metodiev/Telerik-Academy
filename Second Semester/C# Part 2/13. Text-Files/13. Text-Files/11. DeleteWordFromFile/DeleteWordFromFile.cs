using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteWordFromFile
{
    static void Main()
    {
        string str = null;;
        using (StreamReader reader = new StreamReader("file.txt"))
        {
            StreamWriter writer = new StreamWriter("newFile.txt");
            using (writer)
            {
                while ((str = reader.ReadLine()) != null)
                {
                    writer.WriteLine(Regex.Replace(str, @"\btest\w*\b", ""));

                }
            }    
        }
    }
}

