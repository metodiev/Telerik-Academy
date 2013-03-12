using System;

/*
 * Write a program that reads from the console a sequence of N integer numbers 
 * and returns the minimal and maximal of them.
 */

class ReturnMinAndMax
{
    static void Main()
    {
        Console.WriteLine("How many numbers you wanna enter");
        int numbers;
        numbers = int.Parse(Console.ReadLine());
        int [] arr = new int [numbers];

        for (int i = 0; i <numbers; i++)
        {
            Console.WriteLine("Enter number {0}", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.WriteLine("Small number of sequence is {0}", arr[0]);
        Console.WriteLine("Large number of sequnce is {0}", arr[numbers-1]);
    }
}

