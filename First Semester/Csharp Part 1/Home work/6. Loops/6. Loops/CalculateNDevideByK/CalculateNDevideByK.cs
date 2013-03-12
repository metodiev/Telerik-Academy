using System;

/*
 * Write a program that calculates N!/K! for given N and K (1<N<K).
 */

class CalculateNDevideByK
{
    static void Main()
    {
        Console.WriteLine("Enter N");
        decimal N;
        N = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter K");
        decimal K;
        K = decimal.Parse(Console.ReadLine());
        int num = 1;
        int secondNum = 1;
        decimal factorial = 1;
        decimal secondFactorial = 1;
        bool condition = ((K > N) && (N > 1));

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
            }
        decimal finalFactorial;
        finalFactorial = factorial / secondFactorial;
        Console.WriteLine("Value of N!/K! is {0}:", finalFactorial);
        }
    }


