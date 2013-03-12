using System;
using System.Text;

//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes


class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
                              "platform for applications from Microsoft",
                              "managed execution environment for .NET",
                              "hierarchical organization of classes"};
        
        string word = Console.ReadLine();

        switch (word)
        {
            case ".NET": Console.WriteLine(dictionary[0]);
                break;
            case "CLR": Console.WriteLine(dictionary[1]);
                break;
            case "namespace": Console.WriteLine(dictionary[2]); break;
            default:
                break;
        }
    }
}

