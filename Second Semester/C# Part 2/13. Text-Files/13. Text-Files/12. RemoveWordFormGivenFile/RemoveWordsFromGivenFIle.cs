using System;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that removes from a text file all words listed in
//given another text file. Handle all possible exceptions in your methods.

class RemoveWordsFromGivenFIle
{
    static void Main()
    {
        try
        {
            string read = File.ReadAllText("file.txt");
          
            StreamReader reader = new StreamReader("inputFile.txt");
            StreamWriter writer = new StreamWriter("outputFile.txt");
        
            using(reader)
	        {
                string str = null;
		        using(writer) 
                {
                    while ((str= reader.ReadLine())!= null)
	                {
	                    writer.WriteLine((Regex.Replace(str, read, "")));
                    }                           
                }
	        }

        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }

        catch (IOException)
        {
            Console.WriteLine("IO exeption");
        }
    }
}

