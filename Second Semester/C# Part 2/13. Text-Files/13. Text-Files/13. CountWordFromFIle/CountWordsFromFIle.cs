using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

//Write a program that reads a list of words from a file words.txt and finds
//how many times each of the words is contained in another file test.txt. 
//The result should be written in the file result.txt and the words should
//be sorted by the number of their occurrences in descending order. Handle
//all possible exceptions in your methods.

class CountWordsFromFIle
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("file.txt");
            int size = words.Length;
            int[] countWords = new int[size];

            StreamReader reader = new StreamReader("fileWithWords.txt");
            string str = null;

            using (reader)
            {
                while ((str = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        countWords[i] += Regex.Matches(str, @"\b" + words[i] + @"\b").Count;
                    }
                }
            }     
            Array.Sort(countWords, words);

            StreamWriter writer = new StreamWriter("words.txt");

            using (writer)
            {
               
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("{0}: {1}", words[i], countWords[i]);
                }
                
            }
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("File not fount");
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory of file not found");
        }

        catch (IOException)
        {
            Console.WriteLine("IO exeption");
        }
    }
}

