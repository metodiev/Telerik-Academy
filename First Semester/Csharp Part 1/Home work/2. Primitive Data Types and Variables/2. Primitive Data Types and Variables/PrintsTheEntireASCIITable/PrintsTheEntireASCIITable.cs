using System;
using System.Text;

class PrintsTheEntireASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (byte counter = 0; counter < 255; counter++)
        {
            Console.WriteLine((char)counter);
        }
    }
}

