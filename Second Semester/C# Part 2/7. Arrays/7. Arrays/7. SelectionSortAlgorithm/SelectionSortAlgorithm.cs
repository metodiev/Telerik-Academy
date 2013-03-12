using System;

//sorting an array means to arrange its elements in increasing order.
//write a program to sort an array. use the "selection sort" algorithm: 
//find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

class selectionsortalgorithm
{
    static void main()
    {
        //enter array lenght
        Console.WriteLine("Enter array lenght");
        int lenght = int.Parse(Console.ReadLine());
        int[] arr = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // sort array with selection sort
        int temp, min;

        for (int j = 0; j < arr.Length - 1; j++)
        {
            min = j;

            for (int k = j + 1; k < arr.Length; k++)
            {
                if (arr[k] < arr[min])
                {
                    min = k;
                }
            }

            temp = arr[min];
            arr[min] = arr[j];
            arr[j] = temp;
        }

        //array after selection sort
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("array[" + i + "] = " + arr[i]);
        }
    }
}

