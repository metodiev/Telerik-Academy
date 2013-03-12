using System;

//Write a program, that reads from the console an array of N 
//integers and an integer K, sorts the array and using the
//method Array.BinSearch() finds the largest number in the array which is ≤ K. 

class ArrayBinSearch
{
    static void Main()
    {
        Console.WriteLine("Enter N (an array length:)");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter K:");
        int K = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter {0} member:", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int index = Array.BinarySearch(arr, K);

        if (index < 0)
        {
            for (int i = index; i > 0; i++)
            {
                if (K < arr[0])
                {
                    break;
                }

                K--;
                index = Array.BinarySearch(arr, K);
            }
        }


        if (index < 0)
        {
            Console.WriteLine("Element not found!");
        }

        else
        {
            Console.WriteLine(" K member: {0} is at index  = {1}", index, arr[index]);
        }
    }
}

