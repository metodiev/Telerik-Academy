using System;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
// N = 3	N = 4


class PrintMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter integer number N (N < 20)");
        int n;
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n+1; i++)
        {
            for (int j = i; j < i+n; j++)
            {
                Console.Write("{0}", j);
            }
            Console.WriteLine();
        }
    }
}

