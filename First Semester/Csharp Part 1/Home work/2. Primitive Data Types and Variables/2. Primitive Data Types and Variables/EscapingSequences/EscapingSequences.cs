using System;

class EscapingSequences
{
    static void Main()
    {
        string firstString = "The \"use\" of quotations causes difficulties.";
        string secondString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("First string content: {0}\nSecond string content: {1}", firstString, secondString);
    }
}

