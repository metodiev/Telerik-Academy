//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George	    Peter


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class SortTextFile
{
    static void Main()
    {
        StreamReader read = new StreamReader("unsort.txt");
        StreamReader readRow = new StreamReader("unsort.txt");
        int row = 0;

        using (readRow)
        {
            while (readRow.ReadLine()!=null)
            {
                row++;
            }
        }

        string [] names = new string [row];
        using (read)
        {
            
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = read.ReadLine();
            }

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
        }

        StreamWriter writer = new StreamWriter("sort.txt");
        Array.Sort(names);
       
        using (writer)
        {
          
            for (int i = 0; i < names.Length; i++)
            {
                writer.Write(names[i]);
                writer.WriteLine();
            }
        }
    }
}

