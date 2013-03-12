using System;
using System.Numerics;

//Input:
//The input data is being read from the console.
//The number N is written on the first input line.
//On each of the following N lines there is one integer number written – the consequent number from the given list of numbers.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data must be printed on the console.
//On the only output line you must print the integer from the list which appears an odd number of times.

//Constraints:
//N will be positive odd integer number between 1 and 99 999, inclusive. 
//All of the numbers in the list will be integer numbers between -9 223 372 036 854 775 808
//and 9 223 372 036 854 775 807, inclusive.

class OddNumber
{
    static void Main()
    {

        long N = long.Parse(Console.ReadLine());

        long[] first = new long[N];
        long[] second = new long[N];
        long temp = 0;
        long[] third = new long[N];
        long number = 0;
        for (long i = 0; i < N; i++)
        {
            first[i] = long.Parse(Console.ReadLine());
 
        }

        for (long i = 0; i < first.Length; i++)
        {
            temp = first[i];
            for (long j = 0; j < N; j++)
            {
                if (temp == first[j])
                {
                    second[i] += 1;
                }
            }
        }
       
        for (long i = 0; i < second.Length; i++)
        {
            if (second[i] % 2 != 0)
            {
                number = i;
            }
           
        }
        Console.WriteLine(first[number]);
    }
}

