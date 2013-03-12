using System;

//Write a program that reads two numbers N and K and generates all the 
//variations of K elements from the set [1..N]. Example:
//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

class VariationsOfNumberFromArray
{
    private static void RecursiveMethod(int [] arr,int n, int index = 0)
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
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                RecursiveMethod(arr, n, index+1);
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

        RecursiveMethod(arr, N);
    }
}

