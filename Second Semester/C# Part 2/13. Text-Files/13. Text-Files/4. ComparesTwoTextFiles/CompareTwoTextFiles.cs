using System;
using System.Text;
using System.IO;
using System.Collections;

//Write a program that compares two text files line by line and prints
//the number of lines that are the same and the number of lines that
//are different. Assume the files have equal number of lines.


class CompareTwoTextFiles
{
   
    static void Main()
    {
        
        StreamReader readFirstFile = new StreamReader("firstFile.txt");
        string readFirst = null;

        using (readFirstFile)
        {
            readFirst = readFirstFile.ReadToEnd();
            //Console.WriteLine(readFirst);
        }

        StreamReader readSecondFile = new StreamReader("secondFile.txt");
        string readSecond = null;

        using (readFirstFile)
        {
            readSecond = readSecondFile.ReadToEnd();
            //Console.WriteLine(readSecond);
        }

        int equalLines = 0;
        int differentLines = 0;

        for (int i = 0; i < readFirst.Length && i < readSecond.Length; i++)
        {
            if (readFirst[i] == readSecond[i])
            {
                equalLines++;
            }

            else
            {
                differentLines++;
            }
        }

        int equal = readFirst.CompareTo(readSecond);

        if (equal == 0)
        {
            Console.WriteLine("Two text files are equal");
            Console.WriteLine("Equal: {0}\nDiferent Lines: {1}", equalLines, differentLines);
        }
        else
        {
            Console.WriteLine("Two text files are not equal");
            Console.WriteLine("Equal: {0}\nDiferent Lines: {1}", equalLines, differentLines);
        }
        
       
    }
}

