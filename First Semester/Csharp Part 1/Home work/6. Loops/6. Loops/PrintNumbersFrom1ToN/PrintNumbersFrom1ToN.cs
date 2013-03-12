/*
 * Write a program that prints all the numbers from 1 to N.
 */
using System;

class PrintNumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter how many numebrs form one you wanna print");
        long numbers;
        numbers = long.Parse(Console.ReadLine());
        
        for (int i = 1; i <= numbers; i++)
        {
            Console.WriteLine(i);
        }
    }
}

