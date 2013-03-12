using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a 
//text file. Ensure it will work with large files (e.g. 100 MB).
//Modify the solution of the previous problem to replace only whole words (not substrings).

class ReplaceWordsOnly
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("file.txt"))
        {
            using (StreamWriter writer = new StreamWriter("temp.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = line.Replace("start", "finish");
                    writer.WriteLine(newLine);
                }
            }
        }

        File.Delete("file.txt");
        File.Move("temp.txt", "file.txt");
            
    }

}