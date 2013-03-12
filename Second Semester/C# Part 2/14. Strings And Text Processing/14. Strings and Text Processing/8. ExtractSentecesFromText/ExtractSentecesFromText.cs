using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

//Write a program that extracts from a given text all words containing given word.
//Example: The word is "in". The text is:

//We are living in a yellow submarine.
//We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is:

//We are living in a yellow submarine.
//We will move out of it in 5 days.

//Consider that the words are separated by "." and the words – by non-letter symbols.

class Program
{
    static void Main()
    {
        string str = "We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string[] words = str.Split('.');
        if (str.Contains("in"))
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.IsMatch(words[i], @"\b" +"in"+  @"\b", RegexOptions.IgnoreCase))
                {
                    Console.WriteLine((words[i] + ".").Trim());
                }
            }
        }

        else
        {
            Console.WriteLine("There is no \"in\" in any sentece ");
        }
       
        
    }
}

