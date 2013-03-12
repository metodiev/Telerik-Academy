using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the N number: ");
        int n;
        n = int.Parse(Console.ReadLine());
        decimal[] numerator = new decimal[(n * 2) + 2];
        decimal sum = 1;
        for (int j = 0, i = 1; i <= (2 * n); j++, i++)
        {
            sum = sum * i;
            numerator[j] = sum;
            //Console.WriteLine(numerator[j]);
        }

        decimal[] denominator = new decimal[n + 2];
        decimal secondSum = 1;

        for (int j = 0, i = 1; i <= (n + 1); j++, i++)
        {
            secondSum = secondSum * i;
            denominator[j] = secondSum;
            //  Console.WriteLine(numerator[j]);
        }

        decimal[] factorial = new decimal[n];
        decimal thirdSum = 1;
        for (int j = 0, i = 1; i <= n; j++, i++)
        {
            thirdSum = thirdSum * i;
            factorial[j] = thirdSum;
            // Console.WriteLine(factorial[j]);
        }

        decimal catalan = 0;
        catalan = (numerator[(2 * n) - 1]) / ((denominator[(n + 1) - 1]) * (factorial[n - 1]));
        Console.WriteLine(catalan);
    }
}
