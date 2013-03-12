using System;
using System.Collections.Generic;
//* Modify your last program and try to make it work for any number type,
//not just integer (e.g. decimal, float, byte, etc.).
//Use generic method (read in Internet about generic methods in C#).

class GenericMethod
{
   
    static void Minimum<T>(params T[] arr)
    {
	    Array.Sort(arr);
        Console.WriteLine("Minimum number: {0}",arr[0]);
    }

     static void Maximum<T>(params T [] arr)
    {
        Array.Sort(arr);
        int length = arr.Length;
        Console.WriteLine("Maximum number: {0}", arr[length-1]);
    }

    static void Average<T>(params T [] arr)
    {
        dynamic average = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            average = average + arr[i];
        }
        average = average / arr.Length;
        Console.WriteLine("Average number: {0}",average);
    }

    static void Sum<T>(params T [] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum of numbers: {0}", sum);
    }

    static void Product<T>(params T[] arr)
    {
        dynamic product = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            product = product * arr[i];
        }
        Console.WriteLine(product);
    }

    static void Main()
    {
        Minimum<int>(5,6,1,2,4,5,55);
        Minimum<double>(5,6,1,2,4,5,55);
        Maximum<int>(5, 6, 1, 2, 4, 5, 55);
        Average(5, 6, 1, 2, 4, 5, 55);
        Sum(5, 6, 1, 2, 4, 5, 55);
        Product(5, 6, 1, 2, 4, 5, 55);
   }  
}

