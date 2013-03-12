using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.


class RecognizeEmail
{
    static void Main()
    {
        string str = "use mail to contact asdasd  kiro@gmail.com";
        string mail = Regex.Match(str, @"\w+@\w+\.\w+").ToString();
        Console.WriteLine(mail);
    }
}

