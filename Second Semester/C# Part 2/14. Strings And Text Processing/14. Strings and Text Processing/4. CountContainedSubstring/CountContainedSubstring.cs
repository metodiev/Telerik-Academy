using System;
using System.Text;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//        Example: The target substring is "in". The text is as follows:

//We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

class CountContainedSubstring
{
    static void Main()
    {
        //string str = "in inasdf in asdf in in ".ToLower();
       string str = "We are living in an yellowsubmarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();
        string sub = "in";

        bool isTrue = str.Contains(sub);
        int count = 0;
        if (isTrue)
        {
            for (int i = 0; i < str.Length-1; i++)
            {
                string s = str.Substring(i, 2);
               // Console.WriteLine(s);

                if (s==sub)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Word ({0}) contained in text {1} times:", sub, count);
    
    }
}

