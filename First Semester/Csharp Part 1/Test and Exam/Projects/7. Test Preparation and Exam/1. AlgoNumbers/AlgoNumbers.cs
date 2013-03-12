using System;

class AlgoNumbers
{
    static void Main()
    {
        int  a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        
        int count = 0;
        for (int i = (int)a; i <= b; i++)
        {
            if (i % p == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

