using System;

//15.Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

class AllPrimeNumbers
{
    static void Main()
    {
        long n = 10000000;
        bool [] arr = new bool [n];

        for (long i = 2; i < Math.Sqrt(n); i++)
        {
            if ((i % 2 != 0) || (i == 2))
            {
                arr[i] = true;
                Console.WriteLine(arr[i]);
            }
            for (long j = i*i; j < n ; j+=i)
            {
                arr[j] = false;
                //Console.WriteLine(arr[j]);
            }
        }
        
    }
}

