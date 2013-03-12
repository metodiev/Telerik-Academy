using System;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented 
//as array of digits by given integer number. 

class Factorial
{
    static void FactorialOfNumber(BigInteger []arr)
    {
        for (long i = 0; i < arr.Length; i++)
        {
            BigInteger factorial = FactorialBigInt(arr[i]);
            Console.WriteLine(factorial);
        }
    }

    static BigInteger FactorialBigInt(BigInteger i )
    {
        BigInteger number = i;
        do
        {
            number *= i;
            i--;
        }
        while (i > 0);
       
        return number;
    }

    static void Main()
    {
        BigInteger[] arr = new BigInteger[100];

        for (int i = 0; i < 100; i++)
        {
            arr[i] = i+1;
        }

        FactorialOfNumber(arr);
    }
}

