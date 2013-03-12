using System;
using System.Text;
using System.Collections;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:

//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

class ChangeSurroundedText
{
    static void UpCase(string str)
    {
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < str.Length - 8; i++)
        {
            if (str.Substring(i, 8) == "<upcase>")
            {
                startIndex = i + 8;
                i = startIndex;
            }

            if (str.Substring(i, 9) == "</upcase>")
            {
                endIndex = i;
                int length = endIndex - startIndex;
                string upperStr = str.Substring(startIndex, length).ToUpper();

                str = str.Remove(startIndex, length);

                str = str.Insert(startIndex, upperStr);

                str = str.Remove(startIndex - 8, 8);
                str = str.Remove(endIndex - 8, 9);
            }
        }

        Console.WriteLine(str);
    }
    static void Main()
    {

        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(str);
        UpCase(str);       
    }
}

