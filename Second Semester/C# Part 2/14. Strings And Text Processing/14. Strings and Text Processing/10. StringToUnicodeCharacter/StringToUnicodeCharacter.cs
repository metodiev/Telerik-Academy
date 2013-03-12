using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//Hi!
//Expected output:
//\u0048\u0069\u0021


class StringToUnicodeCharacter
{
    static int ToChar(char str)
    { 
        int number = 0;
        number = str;
        return number;
    }

    static void Main()
    {
        Console.WriteLine("Entre string");
        string str = Console.ReadLine();
        int number = 0;
        for (int i = 0; i < str.Length; i++)
        {

            number = ToChar(str[i]);
            Console.Write("\\{00:X4}", number);
        }
        
       
    }
}

