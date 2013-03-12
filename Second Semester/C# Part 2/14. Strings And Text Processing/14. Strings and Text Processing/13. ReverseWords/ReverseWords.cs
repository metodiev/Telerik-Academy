using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

//Write a program that reverses the words in given sentence.
//    Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class ReverseWords
{
    static  string []SimpleWords(string str)
    {
        string[] temp = null;
        temp = Regex.Split(str, "[ ]");

        return temp;
    }

    static void Main()
    {
        string str = "C# is not C++, not PHP and not Delphi!";
        ArrayList list = new ArrayList();
        string []temp = (SimpleWords(str));
        
        Array.Reverse(temp);
        string reversedString = null;
        for (int i = 0; i < temp.Length; i++)
        {
            reversedString+= " "+Regex.Replace(temp[i], "[ ]","").ToString();
        }

        Console.WriteLine(reversedString);

    }
}

