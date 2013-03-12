using System;

//Write a program that reads two numbers N and K and generates all 
//the combinations of K distinct elements from the set [1..N]. Example:
//    N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, 
//{2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

class CombinationsOfNumber
{
    private static void RecursiveMethod(int[] arr, int n, int index = 0, int k = 1)
    {
        int size = arr.Length;

        if (index == arr.Length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        else
        {
            for (int i = k=k-1; i <= n; i++)
            {
                arr[index] = i;
                RecursiveMethod(arr, n, index+1, k+k+i);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int K = int.Parse(Console.ReadLine());
        int[] arr = new int[K];

        RecursiveMethod(arr, N, 0 , K);
    }
}

