using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 


class PrintDifferentLetter
{
    static void Main()
    {
        string str = "aa dd ff aa ff aa ff aa ff aaff ";
        str = Regex.Replace(str, " ", "");

        //Console.WriteLine(str);
        var grouped = str
            .GroupBy(s => s)
            .Select(group => new { Word = group.Key, Count = group.Count() });

        foreach (var item in grouped)
        {
            Console.WriteLine(item);
        }


    }
}

