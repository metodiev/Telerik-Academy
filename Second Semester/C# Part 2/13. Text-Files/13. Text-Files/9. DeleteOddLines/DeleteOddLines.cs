using System;
using System.IO;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DeleteOddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("odd.txt"))
        {
            using (StreamWriter writer = new StreamWriter("temp.txt"))
            {
                int emptyLine = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (emptyLine % 2 != 0)
                    {
                        emptyLine++;
                    }

                    else
                    {
                        writer.WriteLine(line);
                        emptyLine++;
                    }
                    
                    line = reader.ReadLine();
                }
            }
        }
        File.Replace("temp.txt", "odd.txt", null);
    }
       
}

