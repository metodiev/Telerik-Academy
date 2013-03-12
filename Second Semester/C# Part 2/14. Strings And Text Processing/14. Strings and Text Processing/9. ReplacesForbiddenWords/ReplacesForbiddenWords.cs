using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
//We are given a string containing a list of forbidden words and a text
//containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:

//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
//        The expected result:

//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.


class ReplacesForbiddenWords
{   //second Option
    //private static string []ConvertToString(string str)
    //{
    //    string [] temp = null;
    //    temp = Regex.Split(str, "[ ]");
    //    return temp;
    //}

    static void Main()
    {
        string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbidden =  @"\b(PHP|CLR|Microsoft)\b";

        string clean = null;
        foreach(var st in str)
        {
           clean = Regex.Replace(str, forbidden,"***");   
        }
        Console.WriteLine(clean);

        ////Second option
        //ArrayList list = new ArrayList();
        
        //string []temp =(ConvertToString(str));
        //for (int r = 0; r < temp.Length; r++)
        //{
        //    list.Add(temp[r]);
        //}
                
        ////foreach (var item in list)
        ////{
        ////    Console.WriteLine(item);
        ////}
        //string cleanString = null;
        //string [] words= list.ToArray(typeof(string)) as string[];
        //for (int i = 0; i < words.Length; i++)
        //{
        //    cleanString += " "+Regex.Replace(words[i], forbidden, " * ");

        //}
        //Console.WriteLine(cleanString);

    }
}

