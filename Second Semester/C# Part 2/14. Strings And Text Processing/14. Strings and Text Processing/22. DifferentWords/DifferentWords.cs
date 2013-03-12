using System;
using System.Text;
using System.Linq;
//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.


class DifferentWords
{
    static void Main(string[] args)
    {
        string str = "aa dd ff aa ff aa ff aa ff aaff ";

       var grouped = str.Split(' ')
           .GroupBy(s => s)
           .Select(group => new { Word = group.Key, Count = group.Count() });

       foreach (var item in grouped)
       {
           Console.WriteLine(item);
       }
       
    }
}

