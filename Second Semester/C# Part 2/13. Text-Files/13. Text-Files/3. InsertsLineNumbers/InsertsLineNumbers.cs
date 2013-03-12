using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

//Write a program that reads a text file and inserts line numbers in front
//of each of its lines. The result should be written to another text file.

class InsertsLineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        int count = 0;
        using (reader)
        {
            StreamWriter writer = new StreamWriter("lineNumbers.txt");
            using (writer)
            {
                string str = null;
                while ((str = reader.ReadLine()) != null)
                {
                    writer.Write("{0}:", count);
                    writer.WriteLine(str);
                    count++;
                }

            }
        }
        
       
    }
}

