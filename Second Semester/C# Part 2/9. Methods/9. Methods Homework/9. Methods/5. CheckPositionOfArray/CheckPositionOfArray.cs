using System;

//Write a method that checks if the element at given position in given array of integers is
//bigger than its two neighbors (when such exist).

class CheckPositionOfArray
{
    static void CheckArrayNumber(int position, int [] arr)
    {
        bool isBigger = false;
        int check = arr.Length-1;

        if ((position - 1 ) < 0 || (position +1) > check )
        {
            Console.WriteLine("There is no neighbors");
            
        }

        else if (arr[position] > arr[position-1] && arr[position] > arr[position+1])
        {
            isBigger = true;
            Console.WriteLine("Element is bigger than its two neighbors");
        }
        else
        {
            Console.WriteLine("Element is not bigger than its two neighbors");    
        }
       
    }

    static void Main()
    {
        Console.WriteLine("Enter array length:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter {0} member:",i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter position in array between 0 and {0}", arr.Length-1);
        int position = int.Parse(Console.ReadLine());
        CheckArrayNumber(position, arr);
    }
}

