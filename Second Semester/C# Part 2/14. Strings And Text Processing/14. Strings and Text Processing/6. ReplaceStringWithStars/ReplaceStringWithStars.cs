using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be
//filled with '*'. Print the result string into the console.

class ReplaceStringWithStars
{
    static void Main()
    {
        Console.WriteLine("Enter string (max 20 characters)");
        string str = Console.ReadLine();
        int length = str.Length;

        if (length < 20)
	    {
            
            str = Regex.Replace(str,"[0-9, a-z, A-Z,/, ;]","*");
                
        }

        Console.WriteLine(str);
	}
}

