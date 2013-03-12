using System;

/*
 * Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
 */

class CalculateNandK
{
    static void Main()
    {
        Console.WriteLine("Enter N:" );
        int N;
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int K;
        K = int.Parse(Console.ReadLine());
        long factorial = 1;
        long secondFactorial = 1;
        long thirdFactorial = 1;
        int num = 1;
        int secondNum = 1;
        int thirdNum = 1;
        bool condition = ((N < K) && (N > 1));

        if (condition)
        {
            while (num > 0 && num <= N)
            {
                factorial *= num;
                num++;
               // Console.WriteLine("N factorial: {0}", factorial);
            }

            while (secondNum > 0 && secondNum <= K)
            {
                secondFactorial *= secondNum;
                secondNum++;
                //Console.WriteLine("K factorial:{0}", secondFactorial);
            }

            while (thirdNum > 0 && thirdNum <= (K - N))
            {
                thirdFactorial *= thirdNum;
                thirdNum++;
                //Console.WriteLine("K-N factorial:{0}", thirdFactorial);
            }
        }

        decimal finalFactorial = ((factorial * secondFactorial)) / (thirdFactorial);
        Console.WriteLine("Value of ( N!*K!/(K-N)! ):{0}", finalFactorial);
    }
}
