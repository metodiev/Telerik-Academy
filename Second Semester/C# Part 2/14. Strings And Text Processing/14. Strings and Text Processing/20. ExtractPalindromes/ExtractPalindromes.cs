using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class ExtractPalindromes
{
    static string ReverseWords(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string temp = null;
        for (int i = 0; i < str.Length; i++)
        {
            temp += charArray[i];
        }
     
        //second option
        //StringBuilder sb = new StringBuilder();
        //for (int i = str.Length - 1; i >= 0; i--)
        //    sb.Append(str[i]);
        //return sb.ToString();

       // Console.WriteLine(temp);
        return temp;
    }

    static void Main()
    {
        string str = "ABBA da ad oasdf aa bb";
        string second = null;
        second = ReverseWords(str);
        //Console.WriteLine(str);
        //Console.WriteLine(second);
        second = Regex.Replace(second, " ", "");
       
        str = Regex.Replace(str, second, "");
        Console.WriteLine(second);
        
       
        

    }
}

