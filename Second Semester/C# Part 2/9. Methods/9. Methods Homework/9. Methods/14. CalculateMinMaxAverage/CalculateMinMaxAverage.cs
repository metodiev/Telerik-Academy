using System;
//Write methods to calculate minimum, maximum, average, 
//sum and product of given set of integer numbers. Use variable number of arguments.

class CalculateMinMaxAverage
{
    static void Minimum(params int [] arr)
    {
        Array.Sort(arr);
        Console.WriteLine("Minimum number: {0}",arr[0]);

    }

    static void Maximum(params int [] arr)
    {
        Array.Sort(arr);
        int length = arr.Length;
        Console.WriteLine("Maximum number: {0}", arr[length-1]);
    }

    static void Average(params int [] arr)
    {
        decimal average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        average = average / arr.Length;
        Console.WriteLine("Average number: {0}",average);
    }

    static void Sum(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum of numbers: {0}",sum);
    }
    static void Product(params int [] arr)
    {
        int  product = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            product = product * arr[i];
        }
        Console.WriteLine("Product: {0}",product);
    }

    static void Main()
    {
       
        Minimum(5,6,1,2,4,5,55);
        Maximum(5, 6, 1, 2, 4, 5, 55);
        Average(5, 6, 1, 2, 4, 5, 55);
        Sum(5, 6, 1, 2, 4, 5, 55);
        Product(5, 6, 1, 2, 4, 5, 55);

    }
}

