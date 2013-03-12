using System;
using System.IO;
//Write a program that reads a text file and prints on the console its odd lines.


class PrintTextOddLines
{
    static void Main()
    {
        StreamReader read = new StreamReader("symbols.txt");
        using (read)
        {
            string symbol = read.ReadLine();
            //Console.WriteLine(symbol);
            for (int i = 0; i < symbol.Length; i++)
            {
                if ( (i%2) !=0)
                {
                    Console.WriteLine(symbol[i]);
                }
            }
        }

    }
}

