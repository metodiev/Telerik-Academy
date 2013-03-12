/*
 * Write a program that prints all the numbers from 1 to N,
 * that are not divisible by 3 and 7 at the same time.
 */
using System;

class NumbersNotDvisibleBy7and3
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers you wanna print");
        long numbers;
        numbers = long.Parse(Console.ReadLine());
   
        bool expression;

        for (long i = 0; i < numbers; i++)
        {
            expression = (!((i % 3) == 0) && (!((i % 7) == 0)));
            if (expression)
            {
                Console.WriteLine(i);
            }
        }
    }
}

