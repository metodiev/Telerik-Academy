using System;

//8. Write a program that reads an integer number n 
//from the console and prints all the numbers in
//the interval [1..n], each on a single line.

class SequenceOfnumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers you wanna be the sequnce");
        int numbers;
        numbers = int.Parse(Console.ReadLine());
        int [] sequnece = new int [numbers];
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Enter {0} number", i);
            sequnece [i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Number {0} of sequence: is {1}", i, sequnece[i]);
        }
    }
}
