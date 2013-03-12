using System;

class CheckTheSum
{
    static void Main()
    {
        long S = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long[] arr = new long[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }
        long[] compare = new long[N];
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            if (arr[i] == S)
            {
                count++;
            }

            for (int j = 0; j < N; j++)
            {
                if (compare[0] != arr[i])
                {
                    if (arr[i] + arr[j] == S)
                    {
                        count ++;
                        compare[0]= arr[i];
                    }
                }
            }
        }

        Console.WriteLine(count);

    }
}