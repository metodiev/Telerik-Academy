using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".


class ReplaceIdenticalLetters
{
    static void Main()
    {
        string read = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder str = new StringBuilder(read);

        for (int i = 0, j = 0; i < str.Length - 1; i++, j++)
        {
            char letter = str[i];
            while (j < str.Length - 1 && letter == str[j + 1])
            {
                str.Remove(j + 1, 1);
            }
        }

        Console.WriteLine(str);
    }
}

