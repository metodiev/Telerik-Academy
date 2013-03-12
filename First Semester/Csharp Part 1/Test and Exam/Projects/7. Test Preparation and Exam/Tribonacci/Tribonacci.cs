using System;
using System.Numerics;

//Input
//The input data should be read from the console.
//The values of the first three Tribonacci elements will be given on the first three input lines.
//The number N will be on the fourth line. This is the number of the consecutive element of the sequence that must be found by your program.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data should be printed on the console.
//At the only output line you must print the Nth element of the given Tribonacci sequence.

//Constraints:
//The values of the first three elements of the sequence will be integers between -2 000 000 000 and 2 000 000 000.
//The number N will be a positive integer between 1 and 15 000, inclusive.


class Program
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        BigInteger sumArr = 0;

        if (N >= 4)
        {
            for (int i = 4; i <= N; i++)
            {
                sumArr  = first + second + third;
                first = second;
                second = third;
                third = sumArr;

            }
            Console.WriteLine(third);
        }
        else if (N == 1)
        {
            Console.WriteLine(first);
        }
        else if (N == 2)
        {
            Console.WriteLine(second);
        }
        else if (N == 3)
        {
            Console.WriteLine(third);
        }
    }
}

