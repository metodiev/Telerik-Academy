using System;
using System.IO;

//Write a program that replaces all occurrences of the substring "start" with the substring 
//"finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

class StartAndFinishInText
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        StreamWriter writer = new StreamWriter("temp.txt");
        string str = null;
        using (reader)
        {
            using (writer)
            {
                while ((str = reader.ReadLine())!= null)
                {
                    string finish = str.Replace("start", "finish");
                    writer.WriteLine(finish);
                }      
            }
        }

        File.Replace("temp.txt", "finish.txt", null);
    }
}

