using System;

//Input:
//The input data is being read from the console.
//The input data will consist of 5 lines.
//The numbers a, b, c, d and e will each be on a single line.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data must be printed on the console.
//On the only output line you must print the least majority multiple of the given numbers.

//Constraints:
//a, b, c, d and e will each be integer numbers between 1 and 100, inclusive. 
//a, b, c, d and e will be distinct.


class LeastMaiorityMultiple
{
    static void Main()
    {
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         int c = int.Parse(Console.ReadLine());
         int d = int.Parse(Console.ReadLine());
         int e = int.Parse(Console.ReadLine());
         long [] arrSum = new long[900000];

        for (long i = 1; i < 9000000; i++)
        {
            if (i % a == 0)
            {
                arrSum[i] += 1;
            }
            if (i % b == 0)
            {
                arrSum[i] += 1;
            }
            if (i % c == 0)
            {
                arrSum[i] += 1;
            }
            if (i % d == 0)
            {
                arrSum[i] += 1;
            }
            if (i % e == 0)
            {
                arrSum[i] += 1;
            }
            if (arrSum[i] >= 3)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}

