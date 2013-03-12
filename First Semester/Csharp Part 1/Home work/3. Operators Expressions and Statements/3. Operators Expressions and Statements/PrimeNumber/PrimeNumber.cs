using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter integer number");
        int number;
        number = int.Parse(Console.ReadLine());
        bool isPrime = false;
        for (long i = 2; i <= number; i = i + 1)
        {
            
            if ((i % 2 != 0) || (i == 2))
            {
                isPrime = true;
            }
            else
            {
                isPrime = false;
            }
        }

        Console.WriteLine("Entered number is prime: {0}", isPrime);
    }
}


