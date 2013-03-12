using System;

//Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

class IndexOfFirstElement
{
    static void ReturnBiggerIndex(int [] arr)
    {
        int index = 0;
        int indexInArr = -1;
        int check = arr.Length - 1;
        for (int i = 0, j=1, p=2; (i < arr.Length) && (j < arr.Length) && (p < arr.Length); i++, j++, p++)
        {
            if ((arr[j] > arr[i]) && (arr[j] > arr[p]))
            {
                index = arr[j];
                indexInArr = j;
            }
        }

        Console.WriteLine("Number {0}, index in array {1}",index, indexInArr);
    }

    static void Main()
    {
        Console.WriteLine("Enter array length:");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter member {0}", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        ReturnBiggerIndex(arr);
    }
}

