using System;
using System.Text;
//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter string symbols:");
        string str = null;
        str = Console.ReadLine();

        int size = str.Length;
        char[] charrArray = new char[size];

        charrArray = str.ToCharArray();
        Array.Reverse(charrArray);

        Console.WriteLine(charrArray);
    }
}

