using System;
using System.Numerics;

//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
// N = 10  N! = 3628800  2
// N = 20  N! = 2432902008176640000  4
// Does your program work for N = 50 000?

class TrailingZerosOfFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter N!");
        int n;
        n = int.Parse(Console.ReadLine());
        BigInteger square = 1;
        //BigInteger sum=1;
        BigInteger zeros = 0;

        for (int i = 1; i <= n;  i++)
        {
            square *= 5;
            //sum = sum * i;
            zeros += (n / square);
        }
        Console.WriteLine(zeros);
    }
}

