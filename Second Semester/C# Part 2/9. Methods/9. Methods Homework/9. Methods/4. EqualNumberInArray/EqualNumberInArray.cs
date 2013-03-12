using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.


public class EqualNumberInArray
{
    public  static int EqualMembersInArray(int [] arr, int num)
    {     
        int longNumber = 0;
        int index = arr.Length - 1;

        //check sequence for equal elements
        for (int i = 0; i < index; i++)
        {
            if (num == arr[i])
            {
                longNumber++;
            }
        }

        return longNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter array length:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter array members:");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter {0} member:", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter number that wanna see how many times appears in array");
        int number = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        int longSequence = EqualMembersInArray(arr, number);

        Console.WriteLine("number {0} appears {1} times", number, longSequence);
    }
}

