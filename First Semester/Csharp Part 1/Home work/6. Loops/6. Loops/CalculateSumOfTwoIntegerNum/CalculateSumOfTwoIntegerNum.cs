using System;

/*
 * Write a program that, for a given two integer numbers N and X,
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
 */

class CalculateSumOfTwoIntegerNum
{
    static void Main()
    {
        Console.WriteLine("Enter X (integer): ");
        int x;
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N (integer): ");
        int n;
        n = int.Parse(Console.ReadLine());
        decimal sum = 1;
        decimal factorial = 1;
        decimal stepen = 1;

        for (int i = 1; i <= n; i++)
        {
            stepen *= x;
            factorial *= i;
            sum += (factorial / stepen);
        }

        Console.WriteLine("Suma(n!)/(x^n)={0}", sum);
    }
}

