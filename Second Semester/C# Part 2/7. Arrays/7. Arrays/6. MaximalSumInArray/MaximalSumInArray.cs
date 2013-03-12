using System;

//Write a program that reads two integer numbers N and K 
//and an array of N elements from the console. Find in 
//the array those K elements that have maximal sum.


class MaximalSumInArray
{
    static void Main()
    {
        //read two integer numbers from the console
        Console.WriteLine("Entre two integers number");
       
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        //eneter elemnts of array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter {0} member of array:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] sort = new int[N];
        Array.Sort(arr);

        //find K elements that have maximal sum
        for (int i = arr.Length-K; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
