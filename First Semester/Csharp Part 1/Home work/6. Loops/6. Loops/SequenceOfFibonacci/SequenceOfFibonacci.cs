using System;
using System.Numerics;

/*
 * Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
 */

class SequenceOfFibonacci
{
    static void Main()
    {
        Console.WriteLine("How many members you want to print: ");
        int N;
        N = int.Parse(Console.ReadLine());
        BigInteger[] sumArray = new BigInteger[N];
        BigInteger arr; 
        BigInteger fibonacci;
        arr = 1;
        fibonacci = 1;
        BigInteger[] sequence = new BigInteger[N];

        for (int i = 0; i < N; i++)
        { 
            sequence[i] = fibonacci;
           //Console.WriteLine(fibonacci);
            sumArray[i] = arr + fibonacci;
            fibonacci = arr;
            arr = sumArray[i];
        }

        BigInteger sum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            //Console.WriteLine(sumOfSequence[i]);
            sum += sequence[i];
        }
        Console.WriteLine("Sum of first {0} numbers of fibonacci is {1:N}", N, sum);
    }
}

