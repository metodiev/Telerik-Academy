using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static int CountWordsModified(string s)
    {
        return Regex.Matches(s, @"[A-Za-z0-9]+").Count;
    }

    static void Main()
    {
        int linesNumber = int.Parse(Console.ReadLine());
        int W = int.Parse(Console.ReadLine());

        string[] str = new string[linesNumber];

        for (int i = 0; i < str.Length; i++)
        {
            str[i] = Console.ReadLine();

        }

        int[] count = new int[linesNumber];

        for (int i = 0; i < str.Length; i++)
        {
            foreach (char c in str[i])
            {
                if (c == ' ')
                {
                    count[i] += 1;
                }
            }
        }

        int word = 0;
        int[] counter = new int[linesNumber];

        for (int i = 0; i < str.Length; i++)
        {
            word = 0;
            StreamReader sr = new StreamReader(
            new MemoryStream(Encoding.ASCII.GetBytes(str[i].ToString())));


            string delim = " ,.";
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter[i] += fields.Length;

            }
        }


        double[] whiteSpace = new double[linesNumber];
        for (int i = 0; i < str.Length; i++)
        {
            whiteSpace[i] = Convert.ToDouble(count[i] / counter[i]);
        }

        int letters = 0;


        for (int i = 0; i < str.Length; i++)
        {
            
            letters = 0;
            foreach (char c in str[i])
            {
                int white = 0;
               
                
                int countW = CountWordsModified(str[i]);
                if (countW == 1)
                {
                    countW = 0;
                    white = Convert.ToInt32(whiteSpace[i]);
                    for (int j = 0; j < white; j++)
                    {
                        Console.Write(" ");
                    }
                }
                if ((c != ' ' || c == ' '))
                {
                    Console.Write(c);
                    
                    letters++;
                }
                if (letters > W)
                {
                    Console.WriteLine();
                }
               
            }
        }
    }
}
    

