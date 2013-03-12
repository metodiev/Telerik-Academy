using System;

class Pillars
{
    static void Main()
    {
        int[,] m = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int bits = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                m[row, col] = (bits >> (7-col)) & 1;
            }

        }
       
        for (int i = 0; i <= 7; i++)
        {
            int leftCount = 0;
            int rightCount = 0;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col > i )
                    {
                        leftCount += m[row, col];
                    }
                    if (col < i)
                    {
                        rightCount += m[row, col];
                    }
                }
            }
            if (leftCount == rightCount)
            {
                Console.WriteLine(7-i);
                Console.WriteLine(leftCount);
                return;

            }
        }
        Console.WriteLine("No");
    }
}

