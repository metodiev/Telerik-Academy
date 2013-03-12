using System;
using System.Text;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.


class IntToAnyFormat
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        string str = number.ToString();

        str = String.Format("{0,10:G}, {0,15:X}, {0,15:P},{0,15:E}", number);
        Console.WriteLine(str);
       
    }
}

