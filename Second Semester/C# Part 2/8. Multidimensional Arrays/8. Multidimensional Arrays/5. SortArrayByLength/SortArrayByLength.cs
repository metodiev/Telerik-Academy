using System;
using System.Linq;
//You are given an array of strings.
//Write a method that sorts the array by 
//the length of its elements 
//(the number of characters composing them).

class SortArrayByLength
{
    static void SortStringArray(string [] arr)
    {
        var sort = from s in arr
                   orderby s.Length ascending
                   select s;

        foreach (string symbols in sort)
        {
            Console.WriteLine(symbols);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number of string elements in array");
        int size = int.Parse(Console.ReadLine());
        string[] arrOfStrings = new string[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("enter {0} member", i);
            arrOfStrings[i] = Console.ReadLine();
        }

        SortStringArray(arrOfStrings);
    }
}

