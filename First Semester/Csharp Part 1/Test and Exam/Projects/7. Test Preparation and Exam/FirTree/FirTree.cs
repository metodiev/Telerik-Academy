using System;

//Input:
//The input data should be read from the console.
//On the only input line you have an integer number N, showing the height of the tree.
//The input data will always be valid and in the format described. There is no need to check it explicitly.

//Output:
//The output data should be printed on the console.
//You must print the fir tree on the console. Each row contains only characters "." (point)  or "*" (asterisk).
//The first row should have exactly one "*" in the middle (that is the top of the tree) and each of the next lines two more.
//The last line should have exactly one asterisk in the middle, showing the stem of the tree.

//Constraints:
//The number N is a positive integer between 4 and 100, inclusive.


class FirTree
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int count = 2;
        int countNext = 1;
        for (int i = 0; i < N - 1; countNext+=2,count+=1,i++)
        {
            for (int p = 0; p < N - count; p++)
            {
                Console.Write(".");
            }
            for (int q = 0; q < countNext; q++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < N - count; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < N - 2; i++)
        {
            Console.Write(".");
        }
        Console.Write("*");
        for (int i = 0; i < N - 2; i++)
        {
            Console.Write(".");
        }
    }
}

