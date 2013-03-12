using System;
using System.Numerics;

//9. Write a program to print the first 100 members of 
//the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13,
//21, 34, 55, 89, 144, 233, 377, …

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
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(fibonacci);
            sumArray[i] = arr + fibonacci;
            fibonacci = arr;
            arr = sumArray[i];
        }        
    }
}

