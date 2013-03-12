using System;

class AlgoSandGlass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int first = N;
        int second = N - (N - 1);
        int secondP = (N - 2);


        //first LIne
        for (int j = 0; j < first; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();


        //Second and Third Line
        for (int i = 0; i <= N - (3 + i); second += 1, secondP -= 2, i++)
        {
            for (int j = 0; j < second; j++)
            {
                Console.Write(".");
            }

            for (int p = 0; p < secondP; p++)
            {
                Console.Write("*");
            }

            for (int q = 0; q < second; q++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        second -= 2;
        secondP += 4;
        for (int i = 0; i < N - (2 + i); second -= 1, secondP += 2, i++)
        {
            for (int p = 0; p < second; p++)
            {
                Console.Write(".");
            }

            for (int j = 0; j < secondP; j++)
            {
                Console.Write("*");
            }

            for (int p = 0; p < second; p++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}


