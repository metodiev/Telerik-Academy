using System;

//Write a method that return the maximal element in a portion
//of array of integers starting at given index. Using it write
//another method that sorts an array in ascending / descending order.


class Program
{
    static int []GetMaxIndex(int []arr, int num)
    {
        int max = arr[num];
        int maxIndex = num;
        for (int i = num; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxIndex = i;
            }
        }
        int []returnArr = { max, maxIndex };
        return returnArr;
    }


    static void SelectionSort(int []arr)
    {
        //selection sort
        //int temp, min;
        //for (int j = 0; j < arr.Length - 1; j++)
        //{
        //    min = j;

        //    for (int k = j + 1; k < arr.Length; k++)
        //    {
        //        if (arr[k] < arr[min])
        //        {
        //            min = k;
        //        }
        //    }

        //    temp = arr[min];
        //    arr[min] = arr[j];
        //    arr[j] = temp;
        //}s

        int[] ascendingOrder = new int[arr.Length];
        int size = arr.Length-1;
        int index = 0;
        int number = 0;
        for (int i = 0, j = arr.Length-1; i < arr.Length; i++, j--)
        {
            int[] newArr = GetMaxIndex(arr, j);
            index = newArr[1];
            number = newArr[0];
           ascendingOrder[i] = number;
          
        }

        Console.WriteLine(" Array in ascending order");
        PrintArr(ascendingOrder);
    }

    static void PrintArr(int []arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("array[" + i + "] = " + arr[i]);
        }
    }

    static void DescendingSort(int []arr)
    {
        int []des =new int [arr.Length];
        int index = 0;
        int number = 0;
        for (int i = 0; i < des.Length; i++)
        {
            int[] newArr = GetMaxIndex(arr, i);
            index = newArr[1];
            number = newArr[0];
            des[i] = number;
           
        }
      
        Console.WriteLine(" Array in descending order");
        PrintArr(des);
    }

    static void Main()
    {
        int[] arr = { 9, 8, 7, 6, 1, 4 ,5};
      
        // Ascending order
        SelectionSort(arr);

        // Descending order
        DescendingSort(arr);
       
    }
}

