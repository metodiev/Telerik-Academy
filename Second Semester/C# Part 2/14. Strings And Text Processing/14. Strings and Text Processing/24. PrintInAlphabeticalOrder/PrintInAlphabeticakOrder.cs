using System;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class PrintInAlphabeticakOrder
{

    private static string []ConvertToString(string str)
   {
        string [] temp = null;
        temp = Regex.Split(str, "[ ]");
       return temp;
    }

    static void Main()
    {
        string str = "word first second third fourth aa bb";


        ArrayList list = new ArrayList();

        string[] temp = (ConvertToString(str));

        for (int r = 0; r < temp.Length; r++)
        {
            list.Add(temp[r]);
        }
        list.Sort();
        string newString = null;

        foreach (var item in list)
        {
           newString += " " + item;
        }
        Console.WriteLine(newString);
        
    }
}

