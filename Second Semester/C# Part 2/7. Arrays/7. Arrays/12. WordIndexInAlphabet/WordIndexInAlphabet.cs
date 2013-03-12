using System;

//12. Write a program that creates an array containing all letters from 
//the alphabet (A-Z). Read a word from the console and print the index of 
//each of its letters in the array.

class WordIndexInAlphabet
{
    static void Main()
    {
        Console.WriteLine("Enter word");
        string word = (Console.ReadLine().ToUpper());

        for (int i = 0; i < word.Length; i++)
        { 
           for (int j = 65,p=0; j < 91; j++,p++)
            {
                if ((word[i] == (char)(j)))
                {
                    Console.WriteLine("Letter {0}:", word[i]);
                    Console.WriteLine(p+1);
                }
            }

        }
    }
}

